// Copyright (c) 2014, Outercurve Foundation.
// All rights reserved.
//
// Redistribution and use in source and binary forms, with or without modification,
// are permitted provided that the following conditions are met:
//
// - Redistributions of source code must  retain  the  above copyright notice, this
//   list of conditions and the following disclaimer.
//
// - Redistributions in binary form  must  reproduce the  above  copyright  notice,
//   this list of conditions  and  the  following  disclaimer in  the documentation
//   and/or other materials provided with the distribution.
//
// - Neither  the  name  of  the  Outercurve Foundation  nor   the   names  of  its
//   contributors may be used to endorse or  promote  products  derived  from  this
//   software without specific prior written permission.
//
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND
// ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING,  BUT  NOT  LIMITED TO, THE IMPLIED
// WARRANTIES  OF  MERCHANTABILITY   AND  FITNESS  FOR  A  PARTICULAR  PURPOSE  ARE
// DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR
// ANY DIRECT, INDIRECT, INCIDENTAL,  SPECIAL,  EXEMPLARY, OR CONSEQUENTIAL DAMAGES
// (INCLUDING, BUT NOT LIMITED TO,  PROCUREMENT  OF  SUBSTITUTE  GOODS OR SERVICES;
// LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION)  HOWEVER  CAUSED AND ON
// ANY  THEORY  OF  LIABILITY,  WHETHER  IN  CONTRACT,  STRICT  LIABILITY,  OR TORT
// (INCLUDING NEGLIGENCE OR OTHERWISE)  ARISING  IN  ANY WAY OUT OF THE USE OF THIS
// SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.

namespace WebsitePanel.Providers.FTP.IIs70.Config
{
    using Microsoft.Web.Administration;
    using System;

    internal class LogFileElement : ConfigurationElement
    {
        public string CustomLogPluginClsid
        {
            get
            {
                return (string) base["customLogPluginClsid"];
            }
            set
            {
                base["customLogPluginClsid"] = value;
            }
        }

        public string Directory
        {
            get
            {
                return (string) base["directory"];
            }
            set
            {
                base["directory"] = value;
            }
        }

        public bool Enabled
        {
            get
            {
                return (bool) base["enabled"];
            }
            set
            {
                base["enabled"] = value;
            }
        }

        public bool LocalTimeRollover
        {
            get
            {
                return (bool) base["localTimeRollover"];
            }
            set
            {
                base["localTimeRollover"] = value;
            }
        }

        public FtpLogExtFileFlags LogExtFileFlags
        {
            get
            {
                return (FtpLogExtFileFlags) base["logExtFileFlags"];
            }
            set
            {
                base["logExtFileFlags"] = (int) value;
            }
        }

        public LoggingRolloverPeriod Period
        {
            get
            {
                return (LoggingRolloverPeriod) base["period"];
            }
            set
            {
                base["period"] = (int) value;
            }
        }

        public long TruncateSize
        {
            get
            {
                return (long) base["truncateSize"];
            }
            set
            {
                base["truncateSize"] = value;
            }
        }
    }
}

