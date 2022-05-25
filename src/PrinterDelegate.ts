import { StarIO10Error } from "./StarIO10Error";

export class PrinterDelegate {
    _onEventSet: () => void = () => {};

    private _onReady: () => void = () => {};
    