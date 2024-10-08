﻿/*
    This file is part of MTF Sound Tool.
    MTF Sound Tool is free software: you can redistribute it
    and/or modify it under the terms of the GNU General Public License
    as published by the Free Software Foundation, either version 3 of
    the License, or (at your option) any later version.
    MTF Sound Tool is distributed in the hope that it will
    be useful, but WITHOUT ANY WARRANTY; without even the implied
    warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
    See the GNU General Public License for more details.
    You should have received a copy of the GNU General Public License
    along with MTF Sound Tool. If not, see <https://www.gnu.org/licenses/>6.
*/

using System.IO;
using Newtonsoft.Json;

namespace MTF.SoundTool.Updater.Helpers
{
    public class Serializer
    {
        #region Serializer

        public static string Serialize<T>(T Data)
        {
            return JsonConvert.SerializeObject(Data, Formatting.Indented);
        }

        public static T Deserialize<T>(string Data)
        {
            return JsonConvert.DeserializeObject<T>(Data);
        }

        #endregion

        #region File Writer

        public static void WriteDataFile(string Path, string Data)
        {
            File.WriteAllText(Path, Data);
        }

        public static string ReadDataFile(string Path)
        {
            return File.ReadAllText(Path);
        }

        #endregion
    }
}
