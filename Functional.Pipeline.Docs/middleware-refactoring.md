# Real life code refactoring

Refactored function is part of ASP.NET Core middleware. The middleware's purpose is to translate SEO-friendly, foreign language image request path to its native origin correspondent. Essentially, it lets serving multi-language image paths without need to maintain and store additional images for foreign languages.

Here's everyday, object-oriented C# version of the function:

```cs
static string LocalizeForeignPathToOrigin(string foreignPath, IStringLocalizer<HomeController> foreignLocalizer)
{
    var directory = Path.GetDirectoryName(foreignPath);
    var extension = Path.GetExtension(foreignPath);
    var photoLabelSplit = Path.GetFileNameWithoutExtension(foreignPath).Split('-');
    var photoLabelFromRequest = string.Join("-", photoLabelSplit.Take(photoLabelSplit.Length - 1));
    photoLabelFromRequest = WebUtility.UrlDecode(photoLabelFromRequest);
    var photoSize = photoLabelSplit.Last();
    var photoKey = foreignLocalizer
        .GetAllStrings()
        .First(localized => localized.Value.ToLower().Contains(photoLabelFromRequest))
        .Name;
    var originLocalizer = foreignLocalizer.WithCulture(OriginCulture);
    var originPhotoDescription = originLocalizer[photoKey].Value;
    var originPhotoLabel = originPhotoDescription
        .ToLower()
        .Substring(0, originPhotoDescription.Length - 1) // omit ending dot '.'
        .ToString();
    var originPath = Path.Combine("/", directory, $"{originPhotoLabel}-{photoSize}{extension}");
    originPath = originPath.Replace(@"\", "/");
    return originPath;
}
```

Below's more functional version of the same function:

```cs
using Functional.Pipeline;
using static Functional.Collections;
using static Functional.String;

static string LocalizeForeignPathToOrigin(string foreignPath, IStringLocalizer<HomeController> foreignLocalizer) =>
    foreignPath.Pipe(
        _ => new
        {
            directory = foreignPath.Pipe(Path.GetDirectoryName),
            extension = foreignPath.Pipe(Path.GetExtension),
            photo = foreignPath.Pipe(
                Path.GetFileNameWithoutExtension,
                path => Split(path, "-"),
                split => new
                {
                    size = split.Last(),
                    label = split.Pipe(
                        s => Take(s, s.Count() - 1), // omit size
                        s => Join(s, "-"),
                        WebUtility.UrlDecode)
                })
        },
        x => new
        {
            x.directory,
            x.extension,
            x.photo.size,
            localizerKey = foreignLocalizer
                .GetAllStrings()
                .First(localized => localized.Value.ToLower().Contains(x.photo.label))
                .Name
        },
        x => foreignLocalizer.WithCulture(OriginCulture).Pipe(
                originLocalizer => originLocalizer[x.localizerKey].Value,
                ToLower,
                SkipLastLetter, // omit ending dot '.'
                photoOriginLabel => Path.Combine("/", x.directory, $"{photoOriginLabel}-{x.size}{x.extension}"),
                originPath => Replace(originPath, @"\", "/")));
```