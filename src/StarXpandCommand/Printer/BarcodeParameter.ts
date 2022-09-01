import { BarcodeSymbology } from './BarcodeSymbology';
import { BarcodeBarRatioLevel } from './BarcodeBarRatioLevel';

export class BarcodeParameter {
    private _content: string;
    private _symbology: BarcodeSymbology;
    private _printHri: boolean = false;
    private _barDots: number = 2;
    private _barRatioLevel: BarcodeBar