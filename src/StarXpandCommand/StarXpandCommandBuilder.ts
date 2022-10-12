import { NativeModules } from 'react-native';
import { BaseStarXpandCommandBuilder } from './BaseStarXpandCommandBuilder';
import { StarIO10ErrorFactory } from '../StarIO10ErrorFactory';
import { StarXpandCommand } from '../../index';

export class StarXpandCommandBuilder extends BaseStarXpandCommandBuilder {
    private _preSetting?: StarXpandCommand.PreSettingBuilder;

    set preSetting(preSetting: StarXpandCommand.PreSettingBuilder | undefined) {
        if(this._preSetting != null) {
            this._removeChild(this._preSetting);
        }

        if (preSetting != null) {
            this._addChild(preSetting);
        }

        this._preSetting = preSetting;
    }

    get preSetting(): StarXpandCommand.PreSettingBuilder | undefined {
        return this._preSetting;
    }

    constructor() {
        super();

        this._addAction(async() => {
            if(this.preSetting != null) {
                await NativeModules.StarXpandCommandBuilderWrapper.setPreSetting(this._nativeObject, this.preSetting._nativeObject)
                .catch(async (nativeError: any) => {
                    va