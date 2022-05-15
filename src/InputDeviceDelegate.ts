import { StarIO10Error } from "./StarIO10Error";

export class InputDeviceDelegate {
    _onEventSet: () => void = () => {};

    private _onConnected: () => vo