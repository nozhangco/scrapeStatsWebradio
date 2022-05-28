import { StarIO10Error } from "./StarIO10Error";

export class PrinterDelegate {
    _onEventSet: () => void = () => {};

    private _onReady: () => void = () => {};
    private _onError: () => void = () => {};
    private _onPaperReady: () => void = () => {};
    private _onPaperNearEmpty: () => void = () => {};
    private _onPaperEmpty: () => void = () => {};
    private _onCoverOpened: () => void = () => {};
    private _onCoverClosed: () => void = () => {};

    onCommunicationError: (error: StarIO10Error) => void = () => {};

    set onReady(value: () => void) {
        this._onReady = value;

        this._onEventSet();
    }

    get onReady(): () => void {
        return this._onReady;
    }

    set onError(value: () => void) {
        this._onError = value;

        this._onEventSet();
    }

    get onError(): () => void {
        return this._onError;
    }

    set onPaperReady(value: () => void) {
        this._onPaperReady = value;

        this._onEventSet();
    }

    get onPaperReady(): () => 