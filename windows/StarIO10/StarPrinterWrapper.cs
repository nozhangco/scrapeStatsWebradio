using Microsoft.ReactNative.Managed;
using StarMicronics.StarIO10;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StarMicronics.ReactNative.StarIO10
{
    [ReactModule]
    class StarPrinterWrapper : StarIO10ObjectWrapper<StarPrinter>
    {
        [ReactEvent]
        public Action<IReadOnlyDictionary<string, JSValue>> PrinterCommunicationError { get; set; }

        [ReactEvent]
        public Action<IReadOnlyDictionary<string, JSValue>> PrinterReady { get; set; }

        [ReactEvent]
        public Action<IReadOnlyDictionary<string, JSValue>> PrinterError { get; set; }

        [ReactEvent]
        public Action<IReadOnlyDictionary<string, JSValue>> PrinterPaperReady { get; set; }

        [ReactEvent]
        public Action<IReadOnlyDictionary<string, JSValue>> PrinterPaperNearEmpty { get; set; }

        [ReactEvent]
        public Action<IReadOnlyDictionary<string, JSValue>> PrinterPaperEmpty { get; set; }

        [ReactEvent]
        public Action<IReadOnlyDictionary<string, JSValue>> PrinterCoverOpened { get; set; }

        [ReactEvent]
        public Action<IReadOnlyDictionary<string, JSValue>> PrinterCoverClosed { get; set; }

        [ReactEvent]
        public Action<IReadOnlyDictionary<string, JSValue>> DrawerCommunicationError { get; set; }

        [ReactEvent]
       