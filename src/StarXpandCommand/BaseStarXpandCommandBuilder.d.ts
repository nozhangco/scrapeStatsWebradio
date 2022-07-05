import { NativeObject } from '../NativeObject';
export declare abstract class BaseStarXpandCommandBuilder extends NativeObject {
    protected _actions: Array<() => Promise<void>>;
    protected _children: Array<BaseStarXpandCommandBuilder>;
    protected _initAllNativeObjects(): Promise<void>;
    protected _disposeAllNativeObjects(): Promise<void>;
    protected _addChild(builder: BaseStarXpandCommandBuilder): void;
 