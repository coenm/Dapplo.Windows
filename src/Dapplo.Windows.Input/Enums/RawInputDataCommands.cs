﻿//  Dapplo - building blocks for desktop applications
//  Copyright (C) 2017-2018  Dapplo
// 
//  For more information see: http://dapplo.net/
//  Dapplo repositories are hosted on GitHub: https://github.com/dapplo
// 
//  This file is part of Dapplo.Windows
// 
//  Dapplo.Windows is free software: you can redistribute it and/or modify
//  it under the terms of the GNU Lesser General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
// 
//  Dapplo.Windows is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU Lesser General Public License for more details.
// 
//  You should have a copy of the GNU Lesser General Public License
//  along with Dapplo.Windows. If not, see <http://www.gnu.org/licenses/lgpl.txt>.

namespace Dapplo.Windows.Input.Enums
{
    /// <summary>
    /// The commands to get the RawInputData
    /// See <a href="https://msdn.microsoft.com/en-us/library/windows/desktop/ms645568.aspx">RAWINPUTDEVICELIST structure</a>
    /// </summary>
    public enum RawInputDataCommands : uint
    {
        /// <summary>
        /// RID_INPUT: Get the raw data from the RAWINPUT structure.
        /// </summary>
        Input = 0x10000003,
        /// <summary>
        /// RID_HEADER: Get the header information from the RAWINPUT structure.
        /// </summary>
        Header = 0x10000005
    }
}
