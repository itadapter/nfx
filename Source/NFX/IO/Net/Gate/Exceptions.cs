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


/* NFX by ITAdapter
 * Originated: 2006.01
 * Revision: NFX 0.3  2009.10.12
 */
using System;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace NFX.IO.Net.Gate
{

  /// <summary>
  /// Throw by NetGate
  /// </summary>
  [Serializable]
  public class NetGateException : NFXException
  {
    public NetGateException()
    {
    }

    public NetGateException(string message)
      : base(message)
    {
    }

    public NetGateException(string message, Exception inner)
      : base(message, inner)
    {
    }

    protected NetGateException(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {

    }
  }

}