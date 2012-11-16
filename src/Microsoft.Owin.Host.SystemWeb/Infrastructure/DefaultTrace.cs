// <copyright file="DefaultTrace.cs" company="Katana contributors">
//   Copyright 2011-2012 Katana contributors
// </copyright>
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;
using System.Diagnostics;

namespace Microsoft.Owin.Host.SystemWeb.Infrastructure
{
    internal class DefaultTrace : ITrace
    {
        private readonly TraceSource _traceSource;

        public DefaultTrace(TraceSource traceSource)
        {
            _traceSource = traceSource;
        }

        public void Write(TraceEventType eventType, string format, params object[] args)
        {
            _traceSource.TraceEvent(eventType, 0, format, args);
        }
    }
}