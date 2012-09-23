// Location.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System;
using System.Runtime.CompilerServices;

namespace System.Html {

    [IgnoreNamespace]
    [Imported]
    public sealed class Location {

        private Location() {
        }

        [ScriptProperty]
        public string Hash {
            get {
                return null;
            }
            set {
            }
        }

        [ScriptProperty]
        public string Hostname {
            get {
                return null;
            }
        }

        [ScriptProperty]
        [ScriptName("host")]
        public string HostnameAndPort {
            get {
                return null;
            }
        }

        [ScriptProperty]
        public string Href {
            get {
                return null;
            }
            set {
            }
        }

        [ScriptProperty]
        public string Pathname {
            get {
                return null;
            }
        }

        [ScriptProperty]
        public string Port {
            get {
                return null;
            }
        }

        [ScriptProperty]
        public string Protocol {
            get {
                return null;
            }
        }

        [ScriptProperty]
        public string Search {
            get {
                return null;
            }
        }

        /// <summary>
        /// Navigates the window to a new location and updates the browser's history.
        /// </summary>
        /// <param name="url">The URL to navigate to.</param>
        public void Assign(string url) {
        }

        /// <summary>
        /// Reload the current document.
        /// </summary>
        public void Reload() {
        }

        /// <summary>
        /// Reload the current document.
        /// </summary>
        /// <param name="forceGet">If true, the document will be reloaded from the server, otherwise it may be loaded from the browser's cache.</param>
        public void Reload(bool forceGet) {
        }

        /// <summary>
        /// Navigates the window to a new location without updating the browser's history.
        /// </summary>
        /// <param name="url">The URL to navigate to.</param>
        public void Replace(string url) {
        }
    }
}
