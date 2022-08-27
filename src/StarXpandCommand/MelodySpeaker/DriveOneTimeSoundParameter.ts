export class DriveOneTimeSoundParameter {
    private _source: string; 
    private _volume: number = -1;

    get source(): string {
        return this._source;
    }

    get volume(): number {
        return this._volume;
    }

 