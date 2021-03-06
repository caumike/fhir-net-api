﻿/* 
 * Copyright (c) 2015, Furore (info@furore.com) and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/ewoutkramer/fhir-net-api/master/LICENSE
 */


using System;
using System.Collections.Generic;
using System.Linq;
using Hl7.Fhir.ElementModel;
using Hl7.FhirPath.Functions;

namespace Hl7.FhirPath
{
    internal static class IValueProviderListExtensions
    {
        public static IEnumerable<IElementNavigator> JustElements(this IEnumerable<IElementNavigator> focus)
        {
            // todo: this is a tautology now --mh
            return focus.OfType<IElementNavigator>();
        }


        public static IEnumerable<IElementNavigator> Children(this IEnumerable<IElementNavigator> focus)
        {
            // todo: this is now a tautology --mh
            // return focus.JustElements().SelectMany(node => node.Children());
            return focus.SelectMany(node => node.Children());
        }

        public static IEnumerable<IElementNavigator> Descendants(this IEnumerable<IElementNavigator> focus)
        {
            return focus.JustElements().SelectMany(node => node.Descendants());
        }
 
    }
}


