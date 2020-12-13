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
     