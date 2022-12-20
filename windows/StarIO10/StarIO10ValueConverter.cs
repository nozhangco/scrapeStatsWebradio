using Microsoft.ReactNative.Managed;
using StarMicronics.StarIO10;
using StarMicronics.StarIO10.StarXpandCommand;
using StarMicronics.StarIO10.StarXpandCommand.Buzzer;
using StarMicronics.StarIO10.StarXpandCommand.Display;
using StarMicronics.StarIO10.StarXpandCommand.Drawer;
using StarMicronics.StarIO10.StarXpandCommand.MelodySpeaker;
using StarMicronics.StarIO10.StarXpandCommand.Presenter;
using StarMicronics.StarIO10.StarXpandCommand.Printer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel;
using Windows.Graphics.Imaging;
using Windows.Storage;
using Windows.Storage.Streams;

namespace StarMicronics.ReactNative.StarIO10
{
    internal class StarIO10ValueConverter
    {
        private static readonly IReadOnlyDictionary<InterfaceType, string> InterfaceTypeDictionary = new Dictionary<InterfaceType, string>()
        {
            { InterfaceType.Lan, "Lan" },
            { InterfaceType.Bluetooth, "Bluetooth" },
            { InterfaceType.BluetoothLE, "BluetoothLE" },
            { InterfaceType.Usb, "Usb" }
        };

        private static readonly IReadOnlyDictionary<StarPrinterModel, string> StarPrinterModelDictionary = new Dictionary<StarPrinterModel, string>()
        {
            { StarPrinterModel.Unknown, "Unknown" },
            { StarPrinterModel.TSP650II, "TSP650II" },
            { StarPrinterModel.TSP700II, "TSP700II" },
            { StarPrinterModel.TSP800II, "TSP800II" },
            { StarPrinterModel.TSP100IIIW, 