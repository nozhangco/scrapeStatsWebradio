import { NativeModules } from 'react-native';
import { BaseStarXpandCommandBuilder } from './BaseStarXpandCommandBuilder';
import { StarIO10ErrorFactory } from '../StarIO10ErrorFactory';
import { StarXpandCommand } from '../../index';

export class DrawerBuilder extends BaseStarXpandCommandBuilder {
    actionOpen(parameter: StarXpandCommand.Drawer.OpenParameter): DrawerBuilder {
     