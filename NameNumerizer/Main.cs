/*
 * MIT License
 *
 * Copyright (c) 2021 Aptivi
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

namespace NameNumerizer
{
    /// <summary>
    /// The entry point class
    /// </summary>
    class EntryPoint
    {
        /// <summary>
        /// Main entry point for the app
        /// </summary>
        static void Main(string[] args)
        {
            // If the arguments were provided, check the passed directory
            if (args.Length > 0)
            {
                if (Directory.Exists(args[0]))
                {
                    try
                    {
                        // Try to numerize the tracks
                        string[] SupportedExtensions = new[] { ".mp3", ".wav", ".ogg", ".aac" };
                        Console.WriteLine("Numerizing tracks...");
                        Core.Tools.Numerizer.NumerizeFiles(args[0], SupportedExtensions);
                        Console.WriteLine("Numerization done!");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Failed to numerize tracks: {0}", ex.Message);
                    }
                }
                else
                {
                    Console.WriteLine("Directory not found.");
                }
            }
            else
            {
                Console.WriteLine("You should specify the directory of the track!");
            }
        }
    }
}
