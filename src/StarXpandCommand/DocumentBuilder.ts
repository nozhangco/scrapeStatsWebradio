import { NativeModules } from 'react-native';
import { BaseStarXpandCommandBuilder } from './BaseStarXpandCommandBuilder';
import { StarIO10ErrorFactory } from '../StarIO10ErrorFactory';
import { StarXpandCommand } from '../../index';

export class DocumentBuilder extends BaseStarXpandCommandBuilder {
    settingTopMargin(height: number): DocumentBuilder {
        this._addAction(async() => {
            await NativeModules.DocumentBuilderWrapper.settingTopMargin(this._nativeObject, height)
            .catch(async (nativeError: any) => {
                var error = await StarIO10ErrorFactory.create(nativeError.code);
                throw error;
            });
        });

        return this;
    }

    settingBlackMark(parameter: StarXpandCommand.Printer.BlackMarkParameter): DocumentBuilder {
        this._addAction(async() => {
            await NativeModules.DocumentBuilderWrapper.settingBlackMark(this._nativeObject, parameter.enable, parameter.position)
            .catch(async (nativeError: any) => {
                var error = await StarIO10ErrorFactory.create(nativeError.code);
                throw error;
            });
        });

        return this;
    }

    settingLabel(parameter: StarXpandCommand.Printer.LabelParameter): DocumentBuilder {
        this._addAction(async() => {
            await NativeModules.DocumentBuilderWrapper.settingLabel(this._nativeObject, parameter.enable)
            .catch(async (nativeError: any) => {
                var error = await StarIO10ErrorFactory.create(nativeError.code);
                throw error;
            });
        });

        return this;
    }

    settingHoldPrint(parameter: StarXpandCommand.Printer.HoldPrintParameter): DocumentBuilder {
        this._addAction(async() => {
  