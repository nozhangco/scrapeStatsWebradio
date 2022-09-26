import { NativeModules } from 'react-native';
import { BaseStarXpandCommandBuilder } from './BaseStarXpandCommandBuilder';
import { StarIO10ErrorFactory } from '../StarIO10ErrorFactory';
import { StarXpandCommand } from '../../index';

export class PrinterBuilder extends BaseStarXpandCommandBuilder {
    styleAlignment(alignment: StarXpandCommand.Printer.Alignment): PrinterBuilder {
        this._addAction(async() => {
            await NativeModules.PrinterBuilderWrapper.styleAlignment(this._nativeObject, alignment)
            .catch(async (nativeError: any) => {
                var error = await StarIO10ErrorFactory.create(nativeError.code);
                throw error;
            });
        });

        return this;
    }

    styleFont(type: StarXpandCommand.Printer.FontType): PrinterBuilder {
        this._addAction(async() => {
            await NativeModules.PrinterBuilderWrapper.styleFont(this._nativeObject, type)
            .catch(async (nativeError: any) => {
                var error = await StarIO10ErrorFactory.create(nativeError.code);
                throw error;
            });
        });

        return this;
    }

    styleBold(enable: boolean): PrinterBuilder {
        this._addAction(async() => {
            await NativeModules.PrinterBuilderWrapper.styleBold(this._nativeObject, enable)
            .catch(async (nativeError: any) => {
                var error = await StarIO10ErrorFactory.create(nativeError.code);
                throw error;
            });
        });

        return this;
    }

