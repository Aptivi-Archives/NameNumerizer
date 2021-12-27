## NameNumerizer

This program lets you numerize all the tracks that are found in the folder of your choice. It renames all the tracks to the format that has the track number prior to the artist and the song name. For example:
```
Before: Allen Watts & Chris Schweizer - Cabrones (Extended Mix).mp3
After:  012. Allen Watts & Chris Schweizer - Cabrones (Extended Mix).mp3
        It's not necessarily number 12. It could be any position in your tracklist.
```
It's written in plain C# with no external dependencies.

### Limitations

Currently, the console application only supports numerizing the tracks that are in these formats: `.mp3, .wav, .ogg, .aac`. However, we hope to expand the support in the future. Meanwhile, use the core library provided.

This library doesn't support .NET Framework 4.8 yet! Sorry about that.

### License

```
MIT License

Copyright (c) 2021 EoflaOE and its companies

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
```
