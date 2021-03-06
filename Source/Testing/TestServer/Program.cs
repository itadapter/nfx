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

using NFX;
using NFX.IO;
using NFX.ApplicationModel;


namespace TestServer
{
    class Program
    {
        static void Main(string[] args)
        {   
          try
          { 
            using(new ServiceBaseApplication(args, null))
            {
                ConsoleUtils.Info("Server is running. ");

                ConsoleUtils.Info("Glue servers:");
                foreach(var s in ServiceBaseApplication.Glues.Servers)
                  Console.WriteLine("  " + s);
                
                Console.WriteLine();
                ConsoleUtils.Info("Press <enter> to end server program");
                Console.ReadLine();
            }
          }
          catch(Exception error)
          {
            ConsoleUtils.Error(error.ToMessageWithType());
            Environment.ExitCode = -1;
          }
        }
    }
}
