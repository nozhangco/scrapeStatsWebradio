import { Channel } from './Channel';

export class DriveParameter {
    private _channel: Channel = Channel.No1; 
    private _repeat: number = 1;
    private _onTime: number = 200;
    private _offTime: number = 200;

    get channel(): Channel {
        return this._channel;
    }

    get repeat(): number {
        return this._repeat;
    }

    get