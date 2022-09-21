import { BaseStarXpandCommandBuilder } from './BaseStarXpandCommandBuilder';
import { StarXpandCommand } from '../../index';
export declare class PrinterBuilder extends BaseStarXpandCommandBuilder {
    styleAlignment(alignment: StarXpandCommand.Printer.Alignment): PrinterBuilder;
    styleFont(type: StarXpandCommand.Printer.FontType): PrinterBuilder;
    styleBold(enable: boolean): PrinterBuilder;
    styleInvert(enable: boolean): PrinterBuilder;
    styleUnderLi