#import "StarIO10ErrorWrapper.h"
#import "StarObjectManager.h"
#import <React/RCTLog.h>

@import StarIO10;


@interface StarIO10ErrorWrapper()

@property(assign, nonatomic) StarObjectManager *objManager;

@end

@implementation StarIO10ErrorWrapper

NSString * const kSTARIO10ErrorTypeArgument = @"Argument";
NSString * const kSTARIO10ErrorTypeBadResponse = @"BadResponse";
NSString * const kSTARIO10ErrorTypeCommunication = @"Communication";
NSString * const kSTARIO10ErrorTypeIllegalDeviceState = @"IllegalDeviceState";
NSString * const kSTARIO10ErrorTypeInUse = @"InUse";
NSString * const kSTARIO10ErrorTypeInvalidOperation = @"InvalidOperation";
NSString * const kSTARIO10ErrorTypeNotFound = @"NotFound";
NSString * const kSTARIO10ErrorTypeUnprintable = @"Unprintable";
NSString * const kSTARIO10ErrorTypeUnsupportedModel = @"UnsupportedModel";
NSString 