import { NativeModules } from 'react-native';
import { StarIO10ArgumentError } from './StarIO10ArgumentError';
import { StarIO10BadResponseError } from './StarIO10BadResponseError';
import { StarIO10CommunicationError } from './StarIO10CommunicationError';
import { StarIO10IllegalDeviceStateError } from './StarIO10IllegalDeviceStateError';
import { StarIO10InUseError } from './StarIO10InUseError';
import { StarIO10InvalidOperationError } from './StarIO10InvalidOperationError';
import { StarIO10NotFoundError } from './StarIO10NotFoundError';
import { StarIO10UnknownError } from './StarIO10UnknownError';
import { StarIO10UnprintableError } from './StarIO10UnprintableError';
import { StarIO10UnsupportedModelError } from './StarIO10UnsupportedModelError';
import { StarPrinterStatusFactory } from './StarPrinterStatusFactory';
import { StarIO10Error } from './StarIO10Error';
import { StarPrinterStatus } from './StarPrinterStatus';

export class StarIO10ErrorFactory {
    static async create(identifier: String): Promise<StarIO10Error> {
        var error;

        try {
            var type = await NativeModules.StarIO10ErrorWrapper.getType(identifier);
            var message = await NativeModules.StarIO10ErrorWrapper.getMessage(identifier);
            var errorCode = await NativeModules.StarIO10ErrorWrapper.getErrorCode(identifier);
            error = await StarIO10ErrorFactory._buildObject(identifier, type, message, errorCode);
        }
        catch(_) {
            error = new StarIO10UnknownError("Failed to create Error.");
