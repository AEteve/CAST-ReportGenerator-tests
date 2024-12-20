﻿/*
 *   Copyright (c) 2019 CAST
 *
 * Licensed under a custom license, Version 1.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License, accessible in the main project
 * source code: Empowerment.
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 *
 */
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using System.Xml.Linq;

namespace CastReporting.Reporting.Builder.BlockProcessing
{
    public class BlockItem
    {
        #region PROPERTIES
        public OpenXmlPartContainer Container { get; set; }
        public XElement XBlock { get; set; }
        //public OpenXmlCompositeElement OxpBlock { get; set; }
        public OpenXmlElement OxpBlock { get; set; }
        #endregion PROPERTIES

        #region METHODES
        /// <summary>
        /// Displayed Text
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Block item - {XBlock?.NodeType.ToString() ?? "?"} - {XBlock?.Name ?? "?"}";
        }
        #endregion
    }
}
