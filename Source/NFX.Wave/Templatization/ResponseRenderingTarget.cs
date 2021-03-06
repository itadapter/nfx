/*<FILE_LICENSE>
* NFX (.NET Framework Extension) Unistack Library
* Copyright 2003-2016 IT Adapter Inc.
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
* http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
</FILE_LICENSE>*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

using NFX.Templatization;

namespace NFX.Wave.Templatization
{
    /// <summary>
    /// Renders into HttpResponse object
    /// </summary>
    public class ResponseRenderingTarget : IRenderingTarget
    {
        public ResponseRenderingTarget(WorkContext work)
        {
          Context = work;
          Response = work.Response;
        }

        /// <summary>
        /// Returns HttpContext for current request
        /// </summary>
        public readonly WorkContext Context;

        /// <summary>
        /// Returns Response object for WorkContext
        /// </summary>
        public readonly Response Response;


        public object Encode(object value)
        {
            if (value==null) return string.Empty;

            return WebUtility.HtmlEncode(value.ToString());
        }

        public void Write(object value)
        {
            Response.Write(value);
        }


        public void Flush()
        {
            Response.Flush();
        }
    }
}
