#import "StarIO10LoggerWrapper.h"
#import <React/RCTLog.h>
#import "StarObjectManager.h"
#import "StarIO10ValueConverter.h"

@interface StarIO10LoggerWrapper()

@property(assign, nonatomic) StarObjectManager *objManager;

@end


@implementation StarIO10LoggerWrapper

- (instancetype)init
{
    self = [super init];
    if (self) {
        _objManager = StarObjectManager.sharedManager;
    }
    return self;
