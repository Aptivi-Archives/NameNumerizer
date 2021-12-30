/*
 * MIT License
 *
 * Copyright (c) 2021 EoflaOE and its companies
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 * SOFTWARE.
 * 
 */

using System.Collections.Generic;
using System.IO;

namespace NameNumerizer.Core.Tools
{
    public static class Numerizer
    {
        /// <summary>
        /// Prepends the filenames with the file number
        /// </summary>
        /// <param name="Path">The target path</param>
        /// <param name="Extensions">Extensions to include (Make sure to include the dot before the extension. For example: .mp3 instead of mp3)</param>
        public static void NumerizeFiles(string Path, string[] Extensions)
        {
            string[] Files = Directory.GetFiles(Path);
            List<string> EnumeratedFiles = new List<string>();

            // Filter the files that we don't need to numerize
            foreach (string File in Files)
            {
                if (Extensions.Length > 0)
                {
                    // We have extensions to be included. Search for them.
                    string FileExtension = System.IO.Path.GetExtension(File);
                    foreach (string Extension in Extensions)
                    {
                        // If the file has an extension that we're looking for, add it to the final list.
                        if (FileExtension == Extension)
                        {
                            EnumeratedFiles.Add(File);
                        }
                    }
                }
                else
                {
                    EnumeratedFiles.AddRange(Files);
                }
            }

            // Actually numerize the files
            for (int FileIndex = 0; FileIndex <= EnumeratedFiles.Count - 1; FileIndex++)
            {
                string File = EnumeratedFiles[FileIndex];
                string FileName = System.IO.Path.GetFileName(File);

                // Append the current count into the file name, but we need to check how many leading zeroes we have to put so it looks like
                // the track number you usually find on music disks, like:
                //
                // "001. Artist - Song" if the last track number has three digits, or
                // "01. Artist - Song"  if the track number has two digits.
                int Digits = EnumeratedFiles.Count.ToString().Length;
                int FileNumber = FileIndex + 1;
                string NumerizedName = FileNumber.ToString().PadLeft(Digits, '0') + ". " + FileName;

                // Finally, form the full path and rename it
                string NumerizedFilePath = System.IO.Path.Combine(Path, NumerizedName);
                if (!System.IO.File.Exists(NumerizedFilePath))
                {
                    System.IO.File.Move(File, NumerizedFilePath);
                }
            }
        }
    }
}
