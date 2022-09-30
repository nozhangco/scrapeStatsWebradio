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

    styleInvert(enable: boolean): PrinterBuilder {
        this._addAction(async() => {
            await NativeModules.PrinterBuilderWrapper.styleInvert(this._nativeObject, enable)
            .catch(async (nativeError: any) => {
                var error = await StarIO10ErrorFactory.create(nativeError.code);
                throw error;
            });
        });

        return this;
    }

    styleUnderLine(enable: boolean): PrinterBuilder {
        this._addAction(async() => {
            await NativeModules.PrinterBuilderWrapper.styleUnderLine(this._nativeObject, enable)
            .catch(async (nativeError: any) => {
                var error = await StarIO10ErrorFactory.create(nativeError.code);
                throw error;
            });
        });

        return this;
    }

    styleMagnification(parameter: StarXpandCommand.MagnificationParameter): PrinterBuilder {
        this._addAction(async() => {
            await NativeModules.PrinterBuilderWrapper.styleMagnification(this._nativeObject, parameter.width, parameter.height)
            .catch(async (nativeError: any) => {
                var error = await StarIO10ErrorFactory.create(nativeError.code);
                throw error;
            });
        });

        return this;
    }

    styleCharacterSpace(width: number): PrinterBuilder {
        this._addAction(async() => {
            await NativeModules.PrinterBuilderWrapper.styleCharacterSpace(this._nativeObject, width)
            .catch(async (nativeError: any) => {
                var error = await StarIO10ErrorFactory.create(nativeError.code);
                throw error;
            });
        });

        return this;
    }

    styleLineSpace(height: number): PrinterBuilder {
        this._addAction(async() => {
            await NativeModules.PrinterBuilderWrapper.styleLineSpace(this._nativeObject, height)
            .catch(async (nativeError: any) => {
                var error = await StarIO10ErrorFactory.create(nativeError.code);
                throw error;
            });
        });

        return this;
    }

    styleHorizontalPositionTo(position: number): PrinterBuilder {
        this._addAction(async() => {
            await NativeModules.PrinterBuilderWrapper.styleHorizontalPositionTo(this._nativeObject, position)
            .catch(async (nativeError: any) => {
                var error = await StarIO10ErrorFactory.create(nativeError.code);
                throw error;
            });
        });

        return this;
    }

    styleHorizontalPositionBy(position: number): PrinterBuilder {
        this._addAction(async() => {
            await NativeModules.PrinterBuilderWrapper.styleHorizontalPositionBy(this._nativeObject, position)
            .catch(async (nativeError: any) => {
                var error = await StarIO10ErrorFactory.create(nativeError.code);
                throw error;
            });
        });

        return this;
    }

    styleHorizontalTabPositions(positions: Array<number>): PrinterBuilder {
        this._addAction(async() => {
            await NativeModules.PrinterBuilderWrapper.styleHorizontalTabPositions(this._nativeObject, positions)
            .catch(async (nativeError: any) => {
                var error = await StarIO10ErrorFactory.create(nativeError.code);
                throw error;
            });
        });

        return this;
    }

    styleInternationalCharacter(type: StarXpandCommand.Printer.InternationalCharacterType): PrinterBuilder {
        this._addAction(async() => {
            await NativeModules.PrinterBuilderWrapper.styleInternationalCharacter(this._nativeObject, type)
            .catch(async (nativeError: any) => {
                var error = await StarIO10ErrorFactory.create(nativeError.code);
                throw error;
            });
        });

        return this;
    }

    styleSecondPriorityCharacterEncoding(type: StarXpandCommand.Printer.CharacterEncodingType): PrinterBuilder {
        this._addAction(async() => {
            await NativeModules.PrinterBuilderWrapper.styleSecondPriorityCharacterEncoding(this._nativeObject, type)
            .catch(async (nativeError: any) => {
                var error = await StarIO10ErrorFactory.create(nativeError.code);
                throw error;
            });
        });

        return this;
    }

    styleCjkCharacterPriority(types: Array<StarXpandCommand.Printer.CjkCharacterType>): PrinterBuilder {
        this._addAction(async() => {
            await NativeModules.PrinterBuilderWrapper.styleCjkCharacterPriority(this._nativeObject, types)
            .catch(async (nativeError: any) => {
                var error = await StarIO10ErrorFactory.create(nativeError.code);
                throw error;
            });
        });

        return this;
    }

    actionCut(type: StarXpandCommand.Printer.CutType): PrinterBuilder {
        this._addAction(async() => {
            await NativeModules.PrinterBuilderWrapper.actionCut(this._nativeObject, type)
            .catch(async (nativeError: any) => {
                var error = await StarIO10ErrorFactory.create(nativeError.code);
                throw error;
            });
        });

        return this;
    }

    actionFeed(height: number): PrinterBuilder {
        this._addAction(async() => {
            await NativeModules.PrinterBuilderWrapper.actionFeed(this._nativeObject, height)
            .catch(async (nativeError: any) => {
                var error = await StarIO10ErrorFactory.create(nativeError.code);
                throw error;
            });
        });

        return this;
    }

    actionFeedLine(lines: number): PrinterBuilder {
        this._addAction(async() => {
            await NativeModules.PrinterBuilderWrapper.actionFeedLine(this._nativeObject, lines)
            .catch(async (nativeError: any) => {
                var error = await StarIO10ErrorFactory.create(nativeError.code);
                throw error;
            });
        });

        return this;
    }

    actionPrintText(content: string): PrinterBuilder {
        this._addAction(async() => {
            await NativeModules.PrinterBuilderWrapper.actionPrintText(this._nativeObject, content