import { StarPrinterModel } from './StarPrinterModel';
import { StarPrinterEmulation } from './StarPrinterEmulation';

export class StarPrinterInformation {
    _model: StarPrinterModel = StarPrinterModel.Unknown;

    _emulation: StarPrinterEmulation = StarPrinterEmulation.Unknown;

    _reserved: Map<string, any | undefined> = new Map<string, any | undefined>()

    get model(): StarPrinterModel {
        return this._mod