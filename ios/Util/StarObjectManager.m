#import "StarObjectManager.h"

@interface StarObjectManager()

@property(nonatomic) NSMutableDictionary<NSString *, id> *objectDict;

@end


@implementation StarObjectManager

static StarObjectManager *sharedData_ = nil;

+ (StarObjectManager *)sharedManager {
    if (sharedData_ == nil) {
        sharedData_ = [StarObjectManager new];
    }
    return sharedData_;
}

- (instancetype)init {
    self = [super init];
    if (self) {
        _objectDict = [NSMutableDictionary new];
    }
    
    return self;
}

- (NSString *)add:(id)obj {
    @synchronized (self) {
        NSString *objID;
        
        while (YES) {
            NSString *_objID = [NSUUID UUID].UUIDString;
           