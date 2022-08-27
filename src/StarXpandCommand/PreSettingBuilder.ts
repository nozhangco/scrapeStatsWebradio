import { NativeModules } from 'react-native';
import { BaseStarXpandCommandBuilder } from './BaseStarXpandCommandBuilder';
import { StarIO10ErrorFactory } from '../StarIO10ErrorFactory';
import { StarXpandCommand } from '../../index';

export class PreSettingBuilder extends BaseStarXpandCommandBuilder {
    addPresenterSetting(builder: StarXpandCommand.PresenterSettingBuilder): PreSettingBuilder {
        this._addChild(builder);

        this._addAction(async() => {
            await NativeModules.PreSettingBuilderWrapper.addPresenterSetting(this._nativeObject, builder._nativeObject)
            .catch(async (nativeError: any) => {
                var error = await StarIO10ErrorFactory.create(nativeError.code);
  