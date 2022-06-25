import { NativeObject } from './NativeObject';
import { StarConnectionSettings } from './StarConnectionSettings';
import { StarPrinterInformation } from './StarPrinterInformation';
import { StarPrinterStatus } from './StarPrinterStatus';
import { PrinterDelegate } from './PrinterDelegate';
import { DrawerDelegate } from './DrawerDelegate';
import { InputDeviceDelegate } from './InputDeviceDelegate';
import { DisplayDelegate } from './DisplayDelegate';
export declare class StarPrinter extends NativeObject {
    private _eventSubscriptions;
    private _connectionSettings;
    private _printerDelegate;
    private _drawerDelegate;
    private _inputDeviceDelegate;
    private _displayDelegate;
    _information: StarPrinterInformation | undefined;
    openTimeout: number;
    printTimeout: number;
    getStatusTimeout: number;
    get information(): StarPrinterInformation | undefined;
    get connectionSettings(): StarConnectionSettings;
    get printerDelegate(): PrinterDelegate;
    get drawerDelegate(): DrawerDelegate;
    get inputDeviceDelegate(): InputDeviceDelegate;
    get displayDelegate(): DisplayDelegate;
    constructor(connectionSettings: StarConnectionSettings);
    open(): Promise<void>;
    print(command