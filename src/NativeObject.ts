import { Lock } from './Lock';

export abstract class NativeObject {
    _nativeObject?: string;
    private _lock: Lock = new Lock();

    protected abstract _initNativeObjectImpl(): Promise<string>;
    protected abstract _disposeNativeObjectImpl(nativeObject: string): Promise<void>;

    protected async _initNativeObject(): Promise<void> {
        await this._lock.lock();

        if (this._nativeObject == null) {
            this._nativeObject = await this._initNativeObjectImpl();
        }

        this._lock.unlock();
    }

    protected async _disposeNativeObject(): Promise<void> {
        await this._lock.lock();

     