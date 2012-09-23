// MessageEvent.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System;
using System.Runtime.CompilerServices;

namespace System.Html {

    [IgnoreNamespace]
    [Imported]
    public sealed class MessageEvent : ElementEvent {

        internal MessageEvent() {
        }

        [ScriptProperty]
        public string Data {
            get {
                return null;
            }
        }

        [ScriptProperty]
        public string Origin {
            get {
                return null;
            }
        }

        [ScriptProperty]
        public WindowInstance Source {
            get {
                return null;
            }
        }
    }
}
