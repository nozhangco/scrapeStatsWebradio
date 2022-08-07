import { NativeModules } from 'react-native';
import { BaseStarXpandCommandBuilder } from './BaseStarXpandCommandBuilder';
import { StarIO10ErrorFactory } from '../StarIO10ErrorFactory';
import { StarXpandCommand } from '../../index';

export class DisplayBuilder extends BaseStarXpandCommandBuilder {
    styleInternationalCharacter(type: StarXpandCommand.Display.InternationalCharacterType): DisplayBuilder {
        this._addAction(async() => {
            await NativeModules.DisplayBuilderWrapper.styleInternationalCharacter(this._nativeObject, type)
            .catch(async (nativeError: any) => {
                var error = await StarIO10ErrorFactory.create(nativeError.code);
                throw error;
            });
        });

        return this;
    }

    styleCharacterEncoding(type: StarXpandCommand.Display.CharacterEncodingType): DisplayBuilder {
        this._addAction(async() => {
            await NativeModules.DisplayBuilderWrapper.styleCharacterEncoding(this._nativeObject, type)
            .catch(async (nativeError: any) => {
                var error = await StarIO10ErrorFactory.create(nativeError.code);
                throw error;
            });
        });

        return this;
    }

    styleCursorPositionTo(parameter: StarXpandCommand.Display.PositionParameter): DisplayBuilder {
        this._addAction(async() => {
            await NativeModules.DisplayBuilderWrapper.styleCursorPositionTo(this._nativeObject, parameter.x, parameter.y)
            .catch(async (nativeError: any) => {
                var error = await StarIO10ErrorFactory.create(nativeError.code);
                throw error;
            });
        });

        return this;
    }

    actionClearLine(): DisplayBuilder {
        this._addAction(async() => {
            await NativeModules.DisplayBuilderWrapper.actionClearLine(this._nativeObject)
            .catch(async (nativeError: any) => {
                var error = await StarIO10ErrorFactory.create(nativeError.code);
                throw error;
            });
        });

        return this;
    }

    actionClearAll(): DisplayBuilder {
        this._addAction(async() => {
            await NativeModules.DisplayBuilderWrapper.actionClearAll(this._nativeObject)
            .catch(async (nativeError: any) => {
                var error = await StarIO10ErrorFactory.create(nativeError.code);
                throw error;
            });
        });

        return this;
    }

    actionSetBackLightState(on: boolean): DisplayBuilder {
        this._addAction(async() => {
            await NativeModules.DisplayBuilderWrapp