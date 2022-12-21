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
            { StarPrinterModel.TSP100IIIW, "TSP100IIIW" },
            { StarPrinterModel.TSP100IIILAN, "TSP100IIILAN" },
            { StarPrinterModel.TSP100IIIBI, "TSP100IIIBI" },
            { StarPrinterModel.TSP100IIIU, "TSP100IIIU" },
            { StarPrinterModel.TSP100IV, "TSP100IV" },
            { StarPrinterModel.mPOP, "mPOP" },
            { StarPrinterModel.mCPrint2, "mC_Print2" },
            { StarPrinterModel.mCPrint3, "mC_Print3" },
            { StarPrinterModel.SMS210i, "SM_S210i" },
            { StarPrinterModel.SMS230i, "SM_S230i" },
            { StarPrinterModel.SMT300,  "SM_T300" },
            { StarPrinterModel.SMT300i, "SM_T300i" },
            { StarPrinterModel.SMT400i, "SM_T400i" },
            { StarPrinterModel.SML200, "SM_L200" },
            { StarPrinterMo