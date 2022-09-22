import { BaseStarXpandCommandBuilder } from './BaseStarXpandCommandBuilder';
import { StarXpandCommand } from '../../index';
export declare class PrinterBuilder extends BaseStarXpandCommandBuilder {
    styleAlignment(alignment: StarXpandCommand.Printer.Alignment): PrinterBuilder;
    styleFont(type: StarXpandCommand.Printer.FontType): PrinterBuilder;
    styleBold(enable: boolean): PrinterBuilder;
    styleInvert(enable: boolean): PrinterBuilder;
    styleUnderLine(enable: boolean): PrinterBuilder;
    styleMagnification(parameter: StarXpandCommand.MagnificationParameter): PrinterBuilder;
    styleCharacterSpace(width: number): PrinterBuilder;
    styleLineSpace(height: number): PrinterBuilder;
    styleHorizontalPositionTo(position: number): PrinterBuilder;
    styleHorizontalPositionBy(position: number): PrinterBuilder;
    styleHorizontalTabPositions(positions: Array<number>): PrinterBuilder;
    styleInternationalCharacter(type: StarXpandCommand.Printer.InternationalCharacterType): PrinterBuilder;
    styleSecondPriorityCharacterEncoding(type: StarXpandCommand.Printer.CharacterEncodingType): PrinterBuilder;
    styleCjkCharacterPriority(types: Array<StarXpandCommand.Printer.CjkCharacterType>): PrinterBuilder;
    actionCut(type: StarXp