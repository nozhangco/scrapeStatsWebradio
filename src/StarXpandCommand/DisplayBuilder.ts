import { NativeModules } from 'react-native';
import { BaseStarXpandCommandBuilder } from './BaseStarXpandCommandBuilder';
import { StarIO10ErrorFactory } from '../StarIO10ErrorFactory';
import { StarXpandCommand } from '../../index';

export class DisplayBuilder extends BaseStarXpandCommandBuilder {
    styleInternationalCharacter(type: StarXpandCommand.Display.Internationa