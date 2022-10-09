import { BaseStarXpandCommandBuilder } from './BaseStarXpandCommandBuilder';
import { StarXpandCommand } from '../../index';
export declare class StarXpandCommandBuilder extends BaseStarXpandCommandBuilder {
    private _preSetting?;
    set preSetting(preSetting: StarXpandCommand.PreSettingBuilder |