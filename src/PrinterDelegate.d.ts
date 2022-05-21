import { StarIO10Error } from "./StarIO10Error";
export declare class PrinterDelegate {
    _onEventSet: () => void;
    private _onReady;
    private _onError;
    private _onPaperReady;
    private _onPaperNearEmpty;
    private _onPaperEmpty;
    private _onCoverOpened;
    private _onCoverClosed;
