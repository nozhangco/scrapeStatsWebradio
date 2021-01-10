//
//  StarIO10ValueConverter.m
//  react-native-star-io10
//
//  Created by 上田　雄磨 on 2020/10/23.
//

#import "StarIO10ValueConverter.h"

@implementation StarIO10ValueConverter

NSDictionary<NSNumber *, NSString *> *kStarPrinterModelDictionary;
NSDictionary<NSNumber *, NSString *> *kStarPrinterEmulationDictionary;
NSDictionary<NSNumber *, NSString *> *kInterfaceTypeDictionary;
NSDictionary<NSNumber *, NSString *> *kPresenterLEDTypeDictionary;
NSDictionary<NSNumber *, NSString *> *kBezelLEDTypeDictionary;
NSDictionary<NSNumber *, NSString *> *kPrinterAlignmentDictionary;
NSDictionary<NSNumber *, NSString *> *kPrinterBlackMarkPositionDictionary;
NSDictionary<NSNumber *, NSString *> *kPrinterFontTypeDictionary;
NSDictionary<NSNumber *, NSString *> *kPrinterInternationalCharacterTypeDictionary;
NSDictionary<NSNumber *, NSString *> *kPrinterCharacterEncodingTypeDictionary;
NSDictionary<NSNumber *, NSString *> *kPrinterCJKCharacterTypeDictionary;
NSDictionary<NSNumber *, NSString *> *kPrinterCutTypeDictionary;
NSDictionary<NSNumber *, NSString *> *kPrinterBarcodeSymbologyDictionary;
NSDictionary<NSNumber *, NSString *> *kPrinterBarcodeBarRatioLevelDictionary;
NSDictionary<NSNumber *, NSString *> *kPrinterPDF417LevelDictionary;
NSDictionary<NSNumber *, NSString *> *kPrinterQRCodeModelDictionary;
NSDictionary<NSNumber *, NSString *> *kPrinterQRCodeLevelDictionary;
NSDictionary<NSNumber *, NSString *> *kDrawerChannelDictionary;
NSDictionary<NSNumber *, NSString *> *kBuzzerChannelDictionary;
NSDictionary<NSNumber *, NSString *> *kMelodySpeakerSoundStorageAreaDictionary;
NSDictionary<NSNumber *, NSString *> *kDisplayCharacterEncodingTypeDictionary;
NSDictionary<NSNumber *, NSString *> *kDisplayContrastDictionary;
NSDictionary<NSNumber *, NSString *> *kDisplayCursorStateDictionary;
NSDictionary<NSNumber *, NSString *> *kDisplayInternationalCharacterTypeDictionary;

+ (void)initialize
{
    static dispatch_once_t oncePredicate;
    dispatch_once(&oncePredicate, ^{
        kStarPrinterModelDictionary = @{
            @(STARIO10StarPrinterModelUnknown): @"Unknown",
            @(STARIO10StarPrinterModelTSP650II): @"TSP650II",
            @(STARIO10StarPrinterModelTSP700II): @"TSP700II",
            @(STARIO10StarPrinterModelTSP800II): @"TSP800II",
            @(STARIO10StarPrinterModelTSP100IIIW): @"TSP100IIIW",
            @(STARIO10StarPrinterModelTSP100IIILAN): @"TSP100IIILAN",
            @(STARIO10StarPrinterModelTSP100IIIBI): @"TSP100IIIBI",
            @(STARIO10StarPrinterModelTSP100IIIU): @"TSP100IIIU",
            @(STARIO10StarPrinterModelTSP100IV): @"TSP100IV", 
            @(STARIO10StarPrinterModelmPOP): @"mPOP",
            @(STARIO10StarPrinterModelmC_Print2): @"mC_Print2",
            @(STARIO10StarPrinterModelmC_Print3): @"mC_Print3",
            @(STARIO10StarPrinterModelSM_S210i): @"SM_S210i",
            @(STARIO10StarPrinterModelSM_S230i): @"SM_S230i",
            @(STARIO10StarPrinterModelSM_T300i): @"SM_T300i",
            @(STARIO10StarPrinterModelSM_T400i): @"SM_T400i",
            @(STARIO10StarPrinterModelSM_L200): @"SM_L200",
            @(STARIO10StarPrinterModelSM_L300): @"SM_L300",
            @(STARIO10StarPrinterModelBSC10): @"BSC10",
            @(STARIO10StarPrinterModelTSP043): @"TSP043",
            @(STARIO10StarPrinterModelSP700): @"SP700",
            @(STARIO10StarPrinterModelTUP500): @"TUP500"
        };
        
        kStarPrinterEmulationDictionary = @{
            @(STARIO10StarPrinterEmulationUnknown): @"Unknown",
            @(STARIO10StarPrinterEmulationStarLine): @"StarLine",
            @(STARIO10StarPrinterEmulationStarDot): @"StarDot",
            @(STARIO10StarPrinterEmulationStarGraphic): @"StarGraphic",
            @(STARIO10StarPrinterEmulationStarPRNT): @"StarPRNT",
            @(STARIO10StarPrinterEmulationEscPos): @"EscPos",
            @(STARIO10StarPrinterEmulationEscPosMobile): @"EscPosMobile"
        };
        
        kInterfaceTypeDictionary = @{
            @(STARIO10InterfaceTypeLAN): @"Lan",
            @(STARIO10InterfaceTypeBluetooth): @"Bluetooth",
            @(STARIO10InterfaceTypeBluetoothLE): @"BluetoothLE",
            @(STARIO10InterfaceTypeUSB): @"Usb"
        };
        
        kPresenterLEDTypeDictionary = @{
            @(STARIO10StarXpandCommandPresenterLEDTypeHolding): @"Holding",
            @(STARIO10StarXpandCommandPresenterLEDTypeError): @"Error",
            @(STARIO10StarXpandCommandPresenterLEDTypeIdle): @"Idle"
        };
        
        kBezelLEDTypeDictionary = @{
            @(STARIO10StarXpandCommandBezelLEDTypeHolding): @"Holding",
            @(STARIO10StarXpandCommandBezelLEDTypeError): @"Error",
            @(STARIO10StarXpandCommandBezelLEDTypeIdle): @"Idle"
        };
        
        kPrinterAlignmentDictionary = @{
            @(STARIO10StarXpandCommandPrinterAlignmentLeft): @"Left",
            @(STARIO10StarXpandCommandPrinterAlignmentCenter): @"Center",
            @(STARIO10StarXpandCommandPrinterAlignmentRight): @"Right"
        };
        
        kPrinterBlackMarkPositionDictionary = @{
            @(STARIO10StarXpandCommandPrinterBlackMarkPositionFront): @"Front",
            @(STARIO10StarXpandCommandPrinterBlackMarkPositionBack): @"Back"
        };
        
        kPrinterFontTypeDictionary = @{
            @(STARIO10StarXpandCommandPrinterFontTypeA): @"A",
            @(STARIO10StarXpandCommandPrinterFontTypeB): @"B"
        };
        
        kPrinterInternationalCharacterTypeDictionary = @{
            @(STARIO10StarXpandCommandPrinterInternationalCharacterTypeUsa): @"Usa",
            @(STARIO10StarXpandCommandPrinterInternationalCharacterTypeFrance): @"France",
            @(STARIO10StarXpandCommandPrinterInternationalCharacterTypeGermany): @"Germany",
            @(STARIO10StarXpandCommandPrinterInternationalCharacterTypeUk): @"UK",
            @(STARIO10StarXpandCommandPrinterInternationalCharacterTypeDenmark): @"Denmark",
            @(STARIO10StarXpandCommandPrinterInternationalCharacterTypeSweden): @"Sweden",
            @(STARIO10StarXpandCommandPrinterInternationalCharacterTypeItaly): @"Italy",
            @(STARIO10StarXpandCommandPrinterInternationalCharacterTypeSpain): @"Spain",
            @(STARIO10StarXpandCommandPrinterInternationalCharacterTypeJapan): @"Japan",
            @(STARIO10StarXpandCommandPrinterInternationalCharacterTypeNorway): @"Norway",
            @(STARIO10StarXpandCommandPrinterInternationalCharacterTypeDenmark2): @"Denmark2",
            @(STARIO10StarXpandCommandPrinterInternationalCharacterTypeSpain2): @"Spain2",
            @(STARIO10StarXpandCommandPrinterInternationalCharacterTypeLatinAmerica): @"LatinAmerica",
            @(STARIO10StarXpandCommandPrinterInternationalCharacterTypeKorea): @"Korea",
            @(STARIO10StarXpandCommandPrinterInternationalCharacterTypeIreland): @"Ireland",
            @(STARIO10StarXpandCommandPrinterInternationalCharacterTypeSlovenia): @"Slovenia",
            @(STARIO10StarXpandCommandPrinterInternationalCharacterTypeCroatia): @"Croatia",
            @(STARIO10StarXpandCommandPrinterInternationalCharacterTypeChina): @"China",
            @(STARIO10StarXpandCommandPrinterInternationalCharacterTypeVietnam): @"Vietnam",
            @(STARIO10StarXpandCommandPrinterInternationalCharacterTypeArabic): @"Arabic",
            @(STARIO10StarXpandCommandPrinterInternationalCharacterTypeLegal): @"Legal"
        };
        
        kPrinterCharacterEncodingTypeDictionary = @{
            @(STARIO10StarXpandCommandPrinterCharacterEncodingTypeJapanese): @"Japanese",
            @(STARIO10StarXpandCommandPrinterCharacterEncodingTypeSimplifiedChinese): @"SimplifiedChinese",
            @(STARIO10StarXpandCommandPrinterCharacterEncodingTypeTraditionalChinese): @"TraditionalChinese",
            @(STARIO10StarXpandCommandPrinterCharacterEncodingTypeKorean): @"Korean",
            @(STARIO10StarXpandCommandPrinterCharacterEncodingTypeCodePage): @"CodePage"
        };
        
        kPrinterCJKCharacterTypeDictionary = @{
            @(STARIO10StarXpandCommandPrinterCJKCharacterTypeJapanese): @"Japanese",
            @(STARIO10StarXpandCommandPrinterCJKCharacterTypeSimplifiedChinese): @"SimplifiedChinese",
            @(STARIO10StarXpandCommandPrinterCJKCharacterTypeTraditionalChinese): @"TraditionalChinese",
            @(STARIO10StarXpandCommandPrinterCJKCharacterTypeKorean): @"Korean"
        };
        
        kPrinterCutTypeDictionary = @{
            @(STARIO10StarXpandCommandPrinterCutTypeFull): @"Full",
            @(STARIO10StarXpandCommandPrinterCutTypePartial): @"Partial",
            @(STARIO10StarXpandCommandPrinterCutTypeFullDirect): @"FullDirect",
            @(STARIO10StarXpandCommandPrinterCutTypePartialDirect): @"PartialDirect"
        };
        
        kPrinterBarcodeSymbologyDictionary = @{
            @(STARIO10StarXpandCommandPrinterBarcodeSymbologyUpcE): @"UpcE",
            @(STARIO10StarXpandCommandPrinterBarcodeSymbologyUpcA): @"UpcA",
            @(STARIO10StarXpandCommandPrinterBarcodeSymbologyJan8): @"Jan8",
            @(STARIO10StarXpandCommandPrinterBarcodeSymbologyEan8): @"Ean8",
            @(STARIO10StarXpandCommandPrinterBarcodeSymbologyJan13): @"Jan13",
            @(STARIO10StarXpandCommandPrinterBarcodeSymbologyEan13): @"Ean13",
            @(STARIO10StarXpandCommandPrinterBarcodeSymbologyCode39): @"Code39",
            @(STARIO10StarXpandCommandPrinterBarcodeSymbologyItf): @"Itf",
            @(STARIO10StarXpandCommandPrinterBarcodeSymbologyCode128): @"Code128",
            @(STARIO10StarXpandCommandPrinterBarcodeSymbologyCode93): @"Code93",
            @(STARIO10StarXpandCommandPrinterBarcodeSymbologyNw7): @"NW7"
        };
        
        kPrinterBarcodeBarRatioLevelDictionary = @{
            @(STARIO10StarXpandCommandPrinterBarcodeBarRatioLevelLevelPlus1): @"LevelPlus1",
            @(STARIO10StarXpandCommandPrinterBarcodeBarRatioLevelLevel0): @"Level0",
            @(STARIO10StarXpandCommandPrinterBarcodeBarRatioLevelLevelMinus1): @"LevelMinus1"
        };
        
        kPrinterPDF417LevelDictionary = @{
            @(STARIO10StarXpandCommandPrinterPDF417LevelEcc0): @"Ecc0",
            @(STARIO10StarXpandCommandPrinterPDF417LevelEcc1): @"Ecc1",
            @(STARIO10StarXpandCommandPrinterPDF417LevelEcc2): @"Ecc2",
            @(STARIO10StarXpandCommandPrinterPDF417LevelEcc3): @"Ecc3",
            @(STARIO10StarXpandCommandPrinterPDF417LevelEcc4): @"Ecc4",
            @(STARIO10StarXpandCommandPrinterPDF417LevelEcc5): @"Ecc5",
            @(STARIO10StarXpandCommandPrinterPDF417LevelEcc6): @"Ecc6",
            @(STARIO10StarXpandCommandPrinterPDF417LevelEcc7): @"Ecc7",
            @(STARIO10StarXpandCommandPrinterPDF417LevelEcc8): @"Ecc8"
        };
        
        kPrinterQRCodeModelDictionary = @{
            @(STARIO10StarXpandCommandPrinterQRCodeModelModel1): @"Model1",
            @(STARIO10StarXpandCommandPrinterQRCodeModelModel2): @"Model2"
        };
        
        kPrinterQRCodeLevelDictionary = @{
            @(STARIO10StarXpandCommandPrinterQRCodeLevelL): @"L",
            @(STARIO10StarXpandCommandPrinterQRCodeLevelM): @"M",
            @(STARIO10StarXpandCommandPrinterQRCodeLevelQ): @"Q",
            @(STARIO10StarXpandCommandPrinterQRCodeLevelH): @"H"
        };
        
        kDrawerChannelDictionary = @{
            @(STARIO10StarXpandCommandDrawerChannelNo1): @"No1",
            @(STARIO10StarXpandCommandDrawerChannelNo2): @"No2"
        };
        
        kBuzzerChannelDictionary = @{
            @(STARIO10StarXpandCommandBuzzerChannelNo1): @"No1",
            @(STARIO10StarXpandCommandBuzzerChannelNo2): @"No2"
        };
        
        kMelodySpeakerSoundStorageAreaDictionary = @{
            @(STARIO10StarXpandCommandMelodySpeakerSoundStorageAreaArea1): @"Area1",
            @(STARIO10StarXpandCommandMelodySpeakerSoundStorageAreaArea2): @"Area2"
        };
        
        kDisplayContrastDictionary = @{
            @(STARIO10StarXpandCommandDisplayContrastPlus3): @"Plus3",
            @(STARIO10StarXpandCommandDisplayContrastPlus2): @"Plus2",
            @(STARIO10StarXpandCommandDisplayContrastPlus1): @"Plus1",
            @(STARIO10StarXpandCommandDisplayContrastDefault): @"Default",
            @(STARIO10StarXpandCommandDisplayContrastMinus1): @"Minus1",
            @(STARIO10StarXpandCommandDisplayContrastMinus2): @"Minus2",
            @(STARIO10StarXpandCommandDisplayContrastMinus3): @"Minus3"
        };
        
        kDisplayCursorStateDictionary = @{
            @(STARIO10StarXpandCommandDisplayCursorStateOn): @"On",
            @(STARIO10StarXpandCommandDisplayCursorStateBlink): @"Blink",
            @(STARIO10StarXpandCommandDisplayCursorStateOff): @"Off"
        };
        
        kDisplayInternationalCharacterTypeDictionary = @{
            @(STARIO10StarXpandCommandDisplayInternationalCharacterTypeUsa): @"Usa",
            @(STARIO10StarXpandCommandDisplayInternationalCharacterTypeFrance): @"France",
            @(STARIO10StarXpandCommandDisplayInternationalCharacterTypeGermany): @"Germany",
            @(STARIO10StarXpandCommandDisplayInternationalCharacterTypeUk): @"UK",
            @(STARIO10StarXpandCommandDisplayInternationalCharacterTypeDenmark): @"Denmark",
            @(STARIO10StarXpandCommandDisplayInternationalCharacterTypeSweden): @"Sweden",
            @(STARIO10StarXpandCommandDisplayInternationalCharacterTypeItaly): @"Italy",
            @(STARIO10StarXpandCommandDisplayInternationalCharacterTypeSpain): @"Spain",
            @(STARIO10StarXpandCommandDisplayInternationalCharacterTypeJapan): @"Japan",
            @(STARIO10StarXpandCommandDisplayInternationalCharacterTypeNorway): @"Norway",
            @(STARIO10StarXpandCommandDisplayInternationalCharacterTypeDenmark2): @"Denmark2",
            @(STARIO10StarXpandCommandDisplayInternationalCharacterTypeSpain2): @"Spain2",
            @(STARIO10StarXpandCommandDisplayInternationalCharacterTypeLatinAmerica): @"LatinAmerica",
            @(STARIO10StarXpandCommandDisplayInternationalCharacterTypeKorea): @"Korea"
        };
        
        kDisplayCharacterEncodingTypeDictionary = @{
            @(STARIO10StarXpandCommandDisplayCharacterEncodingTypeJapanese): @"Japanese",
            @(STARIO10StarXpandCommandDisplayCharacterEncodingTypeSimplifiedChinese): @"SimplifiedChinese",
            @(STARIO10StarXpandCommandDisplayCharacterEncodingTypeTraditionalChinese): @"TraditionalChinese",
            @(STARIO10StarXpandCommandDisplayCharacterEncodingTypeKorean): @"Korean",
            @(STARIO10StarXpandCommandDisplayCharacterEncodingTypeCodePage): @"CodePage"
        };
    });
}

+ (NSData *)toData:(NSArray<NSNumber *> *)values
{
    NSMutableData *data = [NSMutableData data];

    [values enumerateObjectsUsingBlock:^(NSNumber *number, NSUInteger idx, BOOL *stop) {
        // 0x00-0xff の範囲か確認
        if (([number compare:@(0x00)] == NSOrderedAscending) ||
            ([number compare:@(0xff)] == NSOrderedDescending)) {
            *stop = YES;
        }
            
        uint8_t rawByte = number.unsignedCharValue;
        [data appendBytes:&rawByte length:1];
    }];
    
    if (data.length < values.count) {
        return nil;
    }
    
    return data;
}

+ (NSArray<NSNumber *> *)toNumberArray:(NSData *)data
{
    NSMutableArray<NSNumber *> *numberArray = [NSMutableArray array];
    
    uint8_t *bytes = (uint8_t *)data.bytes;
    
    for (NSUInteger i = 0; i < data.length; i++) {
        [numberArray addObject:@(*(bytes + i))];
    }
    
    return numberArray;
}

+ (NSString *)toStringFromStarPrinterModel:(STARIO10StarPrinterModel)value
{
    NSString *result = kStarPrinterModelDictionary[@(value)];
    
    if (result == nil) {
        result = @"Unknown";
    }
    
    return result;
}

+ (NSString *)toStringFromStarPrinterEmulation:(STARIO10StarPrinterEmulation)value
{
    NSString *result = kStarPrinterEmulationDictionary[@(value)];
    
    if (result == nil) {
        result = @"Unknown";
    }
    
    return result;
}

+ (NSString *)toStringFromInterfaceType:(STARIO10InterfaceType)value
{
    return kInterfaceTypeDictionary[@(value)];
}

+ (NSArray<NSNumber *> *)toPrinterCJKCharacterPriorityTypes:(nonnull NSArray<NSString *> *)types
{
    NSMutableArray<NSNumber *> *numberArray = [[NSMutableArray alloc] init];
    
    for (NSString *type in types) {
        STARIO10StarXpandCommandPrinterCJKCharacterType nativeType = [StarIO10ValueConverter toPrinterCJKCharacterType:type];
        [numberArray addObject:@(nativeType)];
    }
    
    return (NSArray *)numberArray;
}

+ (STARIO10StarPrinterModel)toStarPrinterModel:(NSString *)value
{
    NSArray<NSNumber *> *allKeys = [kStarPrinterModelDictionary allKeysForObject:value];
    
    if (allKeys == nil) {
        return STARIO10StarPrinterModelUnknown;
    }
    
    return [[allKeys objectAtIndex:0] intValue];
}

+ (STARIO10InterfaceType)toInterfaceType:(NSString *)value
{
    NSArray<NSNumber *> *allKeys = [kInterfaceTypeDictionary allKeysForObject:value];
    
    if (allKeys == nil) {
        return STARIO10InterfaceTypeUnknown;
    }
    
    return [[allKeys objectAtIndex:0] intValue];
}

+ (STARIO10StarXpandCommandPresenterLEDType)toPresenterLEDType:(NSString *)value
{
    NSArray<NSNumber *> *allKeys = [kPresenterLEDTypeDictionary allKeysForObject:value];
    
    if (allKeys == nil) {
        return STARIO10StarXpandCommandPresenterLEDTypeHolding;
    }
    
    return [[allKeys objectAtIndex:0] intValue];
}

+ (STARIO10StarXpandCommandBezelLEDType)toBezelLEDType:(NSString *)value
{
    NSArray<NSNumber *> *allKeys = [kBezelLEDTypeDictionary allKeysForObject:value];
    
    if (allKeys == nil) {
        return STARIO10StarXpandCommandBezelLEDTypeHolding;
    }
    
    return [[allKeys objectAtIndex:0] intValue];
}

+ (STARIO10StarXpandCommandPrinterAlignment)toPrinterAlignment:(NSString *)value
{
    NSArray<NSNumber *> *allKeys = [kPrinterAlignmentDictionary allKeysForObject:value];
    
    if (allKeys == nil) {
        return STARIO10StarXpandCommandPrinterAlignmentLeft;
    }
    
    return [[allKeys objectAtIndex:0] intValue];
}

+ (STARIO10StarXpandCommandPrinterBlackMarkPosition)toPrinterBlackMarkPosition:(NSString *)value
{
    NSArray<NSNumber *> *allKeys = [kPrinterBlackMarkPositionDictionary allKeysForObject:value];
    
    if (allKeys == nil) {
        return STARIO10StarXpandCommandPrinterBlackMarkPositionFront;
    }
    
    return [[allKeys objectAtIndex:0] intValue];
}

+ (STARIO10StarXpandCommandPrinterFontType)toPrinterFontType:(NSString *)value
{
    NSArray<NSNumber *> *allKeys = [kPrinterFontTypeDictionary allKeysForObject:value];
    
    if (allKeys == nil) {
        return STARIO10StarXpandCommandPrinterFontTypeA;
    }
    
    return [[allKeys objectAtIndex:0] intValue];
}

+ (STARIO10StarXpandCommandPrinterInternationalCharacterType)toPrinterInternationalCharacterType:(NSString *)value
{
    NSArray<NSNumber *> *allKeys = [kPrinterInternationalCharacterTypeDictionary allKeysForObject:value];
    
    if (allKeys == nil) {
        return STARIO10StarXpandCommandPrinterInternationalCharacterTypeUsa;
    }
    
    return [[allKeys objectAtIndex:0] intValue];
}

+ (STARIO10StarXpandCommandPrinterCharacterEncodingType)toPrinterCharacterEncodingType:(NSString *)value
{
    NSArray<NSNumber *> *allKeys = [kPrinterCharacterEncodingTypeDictionary allKeysForObject:value];
    
    if (allKeys == nil) {
        return STARIO10StarXpandCommandPrinterCharacterEncodingTypeCodePage;
    }
    
    return [[allKeys objectAtIndex:0] intValue];
}

+ (STARIO10StarXpandCommandPrinterCJKCharacterType)toPrinterCJKCharacterType:(NSString *)value
{
    NSArray<NSNumber *> *allKeys = [kPrinterCJKCharacterTypeDictionary allKeysForObject:value];
    
    if (allKeys == nil) {
        return STARIO10StarXpandCommandPrinterCJKCharacterTypeJapanese;
    }
    
    return [[allKeys objectAtIndex:0] intValue];
}

+ (STARIO10StarXpandCommandPrinterCutType)toPrinterCutType:(NSString *)value
{
    NSArray<NSNumber *> *allKeys = [kPrinterCutTypeDictionary allKeysForObject:value];
    
    if (allKeys == nil) {
        return STARIO10StarXpandCommandPrinterCutTypePartial;
    }
    
    return [[allKeys objectAtIndex:0] intValue];
}

+ (STARIO10StarXpandCommandPrinterBarcodeSymbology)toPrinterBarcodeSymbology:(NSString *)value
{
    NSArray<NSNumber *> *allKeys = [kPrinterBarcodeSymbologyDictionary allKeysForObject:value];
    
    if (allKeys == nil) {
        return STARIO10StarXpandCommandPrinterBarcodeSymbologyUpcE;
    }
    
    return [[allKeys objectAtIndex:0] intValue];
}

+ (STARIO10StarXpandCommandPrinterBarcodeBarRatioLevel)toPrinterBarcodeBarRatioLevel:(NSString *)value
{
    NSArray<NSNumber *> *allKeys = [kPrinterBarcodeBarRatioLevelDictionary allKeysForObject:value];
    
    if (allKeys == nil) {
        return STARIO10StarXpandCommandPrinterBarcodeBarRatioLevelLevel0;
    }
    
    return [[allKeys objectAtIndex:0] intValue];
}

+ (STARIO10StarXpandCommandPrinterPDF417Level)toPrinterPDF417Level:(NSString *)value
{
    NSArray<NSNumber *> *allKeys = [kPrinterPDF417LevelDictionary allKeysForObject:value];
    
    if (allKeys == nil) {
        return STARIO10StarXpandCommandPrinterPDF417LevelEcc0;
    }
    
    return [[allKeys objectAtIndex:0] intValue];
}

+ (STARIO10StarXpandCommandPrinterQRCodeModel)toPrinterQRCodeModel:(NSString *)value
{
    NSArray<NSNumber *> *allKeys = [kPrinterQRCodeModelDictionary allKeysForObject:value];
    
    if (allKeys == nil) {
        return STARIO10StarXpandCommandPrinterQRCodeModelModel2;
    }
    
    return [[allKeys objectAtIndex:0] intValue];
}

+ (STARIO10StarXpandCommandPrinterQRCodeLevel)toPrinterQRCodeLevel:(NSString *)value
{
    NSArray<NSNumber *> *allKeys = [kPrinterQRCodeLevelDictionary allKeysForObject:value];
    
    if (allKeys == nil) {
        return STARIO10StarXpandCommandPrinterQRCodeLevelL;
    }
    
    return [[allKeys objectAtIndex:0] intValue];
}


+ (STARIO10StarXpandCommandDrawerChannel)toDrawerChannel:(NSString *)value
{
    NSArray<NSNumber *> *allKeys = [kDrawerChannelDictionary allKeysForObject:value];
    
    if (allKeys == nil) {
        return STARIO10StarXpandCommandDrawerChannelNo1;
    }
    
    return [[allKeys objectAtIndex:0] intValue];
}

+ (STARIO10StarXpandCommandBuzzerChannel)toBuzzerChannel:(NSString *)value
{
    NSArray<NSNumber *> *allKeys = [kBuzzerChannelDic