using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MCSConfig {
    public static Dictionary<string, string[]> BLOCK_BLANK_MATERIAL_REGISTRY = new Dictionary<string, string[]>() {
        { "UnityAssetStore/Wooden_Toys_Bundle/ToyBlocks/meshes/Materials/blue_1x1", new string[] { "blue" } },
        { "UnityAssetStore/Wooden_Toys_Bundle/ToyBlocks/meshes/Materials/gray_1x1", new string[] { "grey" } },
        { "UnityAssetStore/Wooden_Toys_Bundle/ToyBlocks/meshes/Materials/green_1x1", new string[] { "green" } },
        { "UnityAssetStore/Wooden_Toys_Bundle/ToyBlocks/meshes/Materials/red_1x1", new string[] { "red" } },
        { "UnityAssetStore/Wooden_Toys_Bundle/ToyBlocks/meshes/Materials/wood_1x1", new string[] { "brown" } },
        { "UnityAssetStore/Wooden_Toys_Bundle/ToyBlocks/meshes/Materials/yellow_1x1", new string[] { "yellow" } }
    };

    public static Dictionary<string, string[]> BLOCK_DESIGN_MATERIAL_REGISTRY = new Dictionary<string, string[]>() {
        { "UnityAssetStore/KD_AlphabetBlocks/Assets/Textures/Blue/TOYBlocks_AlphabetBlock_A_Blue_1K/ToyBlockBlueA", new string[] { "blue", "brown" } },
        { "UnityAssetStore/KD_AlphabetBlocks/Assets/Textures/Blue/TOYBlocks_AlphabetBlock_B_Blue_1K/ToyBlockBlueB", new string[] { "blue", "brown" } },
        { "UnityAssetStore/KD_AlphabetBlocks/Assets/Textures/Blue/TOYBlocks_AlphabetBlock_C_Blue_1K/ToyBlockBlueC", new string[] { "blue", "brown" } },
        { "UnityAssetStore/KD_AlphabetBlocks/Assets/Textures/Blue/TOYBlocks_AlphabetBlock_D_Blue_1K/ToyBlockBlueD", new string[] { "blue", "brown" } },
        { "UnityAssetStore/KD_AlphabetBlocks/Assets/Textures/Blue/TOYBlocks_AlphabetBlock_M_Blue_1K/ToyBlockBlueM", new string[] { "blue", "brown" } },
        { "UnityAssetStore/KD_AlphabetBlocks/Assets/Textures/Blue/TOYBlocks_AlphabetBlock_S_Blue_1K/ToyBlockBlueS", new string[] { "blue", "brown" } },
        { "UnityAssetStore/KD_NumberBlocks/Assets/Textures/Yellow/TOYBlocks_NumberBlock_1_Yellow_1K/NumberBlockYellow_1", new string[] { "yellow", "brown" } },
        { "UnityAssetStore/KD_NumberBlocks/Assets/Textures/Yellow/TOYBlocks_NumberBlock_2_Yellow_1K/NumberBlockYellow_2", new string[] { "yellow", "brown" } },
        { "UnityAssetStore/KD_NumberBlocks/Assets/Textures/Yellow/TOYBlocks_NumberBlock_3_Yellow_1K/NumberBlockYellow_3", new string[] { "yellow", "brown" } },
        { "UnityAssetStore/KD_NumberBlocks/Assets/Textures/Yellow/TOYBlocks_NumberBlock_4_Yellow_1K/NumberBlockYellow_4", new string[] { "yellow", "brown" } },
        { "UnityAssetStore/KD_NumberBlocks/Assets/Textures/Yellow/TOYBlocks_NumberBlock_5_Yellow_1K/NumberBlockYellow_5", new string[] { "yellow", "brown" } },
        { "UnityAssetStore/KD_NumberBlocks/Assets/Textures/Yellow/TOYBlocks_NumberBlock_6_Yellow_1K/NumberBlockYellow_6", new string[] { "yellow", "brown" } }
    };

    public static Dictionary<string, string[]> CERAMIC_MATERIAL_REGISTRY = new Dictionary<string, string[]>() {
        { "AI2-THOR/Materials/Ceramics/BrownMarbleFake 1", new string[] { "brown" } },
        { "AI2-THOR/Materials/Ceramics/ConcreteBoards1", new string[] { "grey" } },
        { "AI2-THOR/Materials/Ceramics/GREYGRANITE", new string[] { "grey" } },
        { "AI2-THOR/Materials/Ceramics/PinkConcrete_Bedroom1", new string[] { "red" } },
        { "AI2-THOR/Materials/Ceramics/RedBrick", new string[] { "red" } },
        { "AI2-THOR/Materials/Ceramics/TexturesCom_BrickRound0044_1_seamless_S", new string[] { "grey" } },
        { "AI2-THOR/Materials/Ceramics/WhiteCountertop", new string[] { "grey" } }
    };

    public static Dictionary<string, string[]> CARDBOARD_MATERIAL_REGISTRY = new Dictionary<string, string[]>() {
        { "AI2-THOR/Materials/Misc/Cardboard_Brown", new string[] { "brown" } },
        { "AI2-THOR/Materials/Misc/Cardboard_Tan", new string[] { "brown" } },
        { "AI2-THOR/Materials/Misc/Cardboard_White", new string[] { "white" } }
    };

    public static Dictionary<string, string[]> FABRIC_MATERIAL_REGISTRY = new Dictionary<string, string[]>() {
        { "AI2-THOR/Materials/Fabrics/Carpet2", new string[] { "brown" } },
        { "AI2-THOR/Materials/Fabrics/Carpet4", new string[] { "blue" } },
        { "AI2-THOR/Materials/Fabrics/CarpetDark", new string[] { "yellow" } },
        { "AI2-THOR/Materials/Fabrics/CarpetGreen", new string[] { "green" } },
        { "AI2-THOR/Materials/Fabrics/CarpetWhite 3", new string[] { "white" } },
        { "AI2-THOR/Materials/Fabrics/HotelCarpet3", new string[] { "red", "black" } },
        { "AI2-THOR/Materials/Fabrics/RugPattern224", new string[] { "green", "brown", "white" } }
    };

    public static Dictionary<string, string[]> METAL_MATERIAL_REGISTRY = new Dictionary<string, string[]>() {
        { "AI2-THOR/Materials/Metals/BlackFoil", new string[] { "black" } },
        { "AI2-THOR/Materials/Metals/BlackSmoothMeta", new string[] { "black" } },
        { "AI2-THOR/Materials/Metals/Brass 1", new string[] { "yellow" } },
        { "AI2-THOR/Materials/Metals/Brass_Mat", new string[] { "yellow" } },
        { "AI2-THOR/Materials/Metals/BrownMetal 1", new string[] { "brown" } },
        { "AI2-THOR/Materials/Metals/BrushedIron_AlbedoTransparency", new string[] { "black" } },
        { "AI2-THOR/Materials/Metals/GenericStainlessSteel", new string[] { "grey" } },
        { "AI2-THOR/Materials/Metals/HammeredMetal_AlbedoTransparency 1", new string[] { "green" } },
        { "AI2-THOR/Materials/Metals/Metal", new string[] { "grey" } },
        { "AI2-THOR/Materials/Metals/WhiteMetal", new string[] { "white" } },
        { "UnityAssetStore/Baby_Room/Models/Materials/cabinet metal", new string[] { "grey" } }
    };

    public static Dictionary<string, string[]> PLASTIC_MATERIAL_REGISTRY = new Dictionary<string, string[]>() {
        { "AI2-THOR/Materials/Plastics/BlackPlastic", new string[] { "black" } },
        { "AI2-THOR/Materials/Plastics/OrangePlastic", new string[] { "orange" } },
        { "AI2-THOR/Materials/Plastics/WhitePlastic", new string[] { "white" } },
        { "UnityAssetStore/Kindergarten_Interior/Models/Materials/color 1", new string[] { "red" } },
        { "UnityAssetStore/Kindergarten_Interior/Models/Materials/color 2", new string[] { "blue" } },
        { "UnityAssetStore/Kindergarten_Interior/Models/Materials/color 3", new string[] { "green" } },
        { "UnityAssetStore/Kindergarten_Interior/Models/Materials/color 4", new string[] { "yellow" } }
    };

    public static Dictionary<string, string[]> RUBBER_MATERIAL_REGISTRY = new Dictionary<string, string[]>() {
        { "AI2-THOR/Materials/Plastics/BlueRubber", new string[] { "blue" } },
        { "AI2-THOR/Materials/Plastics/LightBlueRubber", new string[] { "blue" } }
    };

    public static Dictionary<string, string[]> WALL_MATERIAL_REGISTRY = new Dictionary<string, string[]>() {
        { "AI2-THOR/Materials/Walls/Drywall", new string[] { "white" } },
        { "AI2-THOR/Materials/Walls/DrywallBeige", new string[] { "brown" } },
        { "AI2-THOR/Materials/Walls/DrywallGreen", new string[] { "green" } },
        { "AI2-THOR/Materials/Walls/DrywallOrange", new string[] { "orange" } },
        { "AI2-THOR/Materials/Walls/Drywall4Tiled", new string[] { "white" } },
        { "AI2-THOR/Materials/Walls/EggshellDrywall", new string[] { "blue" } },
        { "AI2-THOR/Materials/Walls/RedDrywall", new string[] { "red" } },
        { "AI2-THOR/Materials/Walls/WallDrywallGrey", new string[] { "grey" } },
        { "AI2-THOR/Materials/Walls/YellowDrywall", new string[] { "yellow" } }
    };

    public static Dictionary<string, string[]> WOOD_MATERIAL_REGISTRY = new Dictionary<string, string[]>() {
        { "AI2-THOR/Materials/Wood/BlackWood", new string[] { "black" } },
        { "AI2-THOR/Materials/Wood/BedroomFloor1", new string[] { "brown" } },
        { "AI2-THOR/Materials/Wood/Cream_wood", new string[] { "white" } },
        { "AI2-THOR/Materials/Wood/DarkWood2", new string[] { "black" } },
        { "AI2-THOR/Materials/Wood/DarkWoodSmooth2", new string[] { "black" } },
        { "AI2-THOR/Materials/Wood/LightWoodCounters 1", new string[] { "brown" } },
        { "AI2-THOR/Materials/Wood/LightWoodCounters3", new string[] { "brown" } },
        { "AI2-THOR/Materials/Wood/LightWoodCounters4", new string[] { "brown" } },
        { "AI2-THOR/Materials/Wood/TexturesCom_WoodFine0050_1_seamless_S", new string[] { "brown" } },
        { "AI2-THOR/Materials/Wood/WhiteWood", new string[] { "white" } },
        { "AI2-THOR/Materials/Wood/WhiteWoodClean", new string[] { "white" } },
        { "AI2-THOR/Materials/Wood/WoodFloorsCross", new string[] { "brown" } },
        { "AI2-THOR/Materials/Wood/WoodGrain_Brown", new string[] { "brown" } },
        { "AI2-THOR/Materials/Wood/WoodGrain_Tan", new string[] { "brown" } },
        { "AI2-THOR/Materials/Wood/WornWood", new string[] { "brown" } },
        { "UnityAssetStore/Kindergarten_Interior/Models/Materials/color wood 1", new string[] { "blue" } },
        { "UnityAssetStore/Kindergarten_Interior/Models/Materials/color wood 2", new string[] { "red" } },
        { "UnityAssetStore/Kindergarten_Interior/Models/Materials/color wood 3", new string[] { "green" } },
        { "UnityAssetStore/Kindergarten_Interior/Models/Materials/color wood 4", new string[] { "yellow" } },
        { "UnityAssetStore/Baby_Room/Models/Materials/wood 1", new string[] { "brown" } }
    };

    public static Dictionary<string, Dictionary<string, string[]>> MATERIAL_REGISTRY = new Dictionary<string, Dictionary<string, string[]>>() {
        { "block_blank", BLOCK_BLANK_MATERIAL_REGISTRY },
        { "block_design", BLOCK_DESIGN_MATERIAL_REGISTRY },
        { "cardboard", CARDBOARD_MATERIAL_REGISTRY },
        { "ceramic", CERAMIC_MATERIAL_REGISTRY },
        { "fabric", FABRIC_MATERIAL_REGISTRY },
        { "metal", METAL_MATERIAL_REGISTRY },
        { "plastic", PLASTIC_MATERIAL_REGISTRY },
        { "rubber", RUBBER_MATERIAL_REGISTRY },
        { "wall", WALL_MATERIAL_REGISTRY },
        { "wood", WOOD_MATERIAL_REGISTRY }
    };

    public static Dictionary<string, string[]> MATERIAL_COLORS = MCSConfig.GenerateMaterialColors();

    private static Dictionary<string, string[]> GenerateMaterialColors() {
        // Hard-code additional materials present in the original playroom scene but not available in the registry.
        Dictionary<string, string[]> materialColors = new Dictionary<string, string[]>() {
            { "childrens floor", new string[] { "blue", "green", "purple", "red", "yellow" } },
            { "crayons", new string[] { "blue" } }, // TODO MCS-264
            { "mattress fabric", new string[] { "white" } },
            { "pacifier", new string[] { "blue" } },
            { "Apple1_Mat1", new string[] { "red" } },
            { "Apple1_Mat2", new string[] { "green" } },
            { "Bowl_Mat5 (Plastic - UB)", new string[] { "brown" } },
            { "Bowl_Mat6 (Plastic - UB)", new string[] { "blue" } },
            { "Cardboard_Mat2", new string[] { "brown" } },
            { "Cardboard_Mat3", new string[] { "brown" } },
            { "Cup5_Mat (Plastic - UB)", new string[] { "black" } },
            { "Plate_Mat1", new string[] { "white" } },
            { "Plate_Mat3", new string[] { "grey" } },
            { "Sofa_velvet.001_AlbedoTransparency", new string[] { "brown" } },
            { "SofaChair_velvet.001_AlbedoTransparency", new string[] { "black" } },
            { "HousePlant_Leaves1A_Mat", new string[] { "green" } },
            { "HousePlant_Leaves2B_Mat", new string[] { "green" } },
            { "HousePlant_Leaves3B_Mat", new string[] { "red" } },
            { "HousePlant_Pot_Primary1_Mat", new string[] { "brown" } },
            { "HousePlant_Pot_Primary3A_Mat", new string[] { "brown" } },
            { "HousePlant_Pot_Primary4_Mat", new string[] { "brown" } },
            { "HousePlant_Pot_Primary5_Mat", new string[] { "grey" } },
            { "HousePlant_Pot_Secondary1_Mat", new string[] { "brown" } },
            { "HousePlant_Pot_Secondary2_Mat", new string[] { "brown" } },
            { "HousePlant_Misc1_Mat", new string[] { "brown" } },
            { "HousePlant_Misc2_Mat", new string[] { "brown" } },
            { "1273482182_9f7b548a17_b", new string[] { "painting" } },
            { "25444100845_88b09f6a33_c", new string[] { "painting" } },
            { "DP259921-1", new string[] { "painting" } },
            { "english-country-village-painting", new string[] { "painting" } },
            { "Kielland-Fra_jaeren", new string[] { "painting" } },
            { "peder-balke-steigen-1849-trivium-art-history", new string[] { "painting" } },
            { "THORKEA_Shelving_Unit_Kallax_Small_Wood_2_Mat", new string[] { "white" } }
        };
        foreach (KeyValuePair<string, Dictionary<string, string[]>> materialType in MCSConfig.MATERIAL_REGISTRY) {
            foreach (KeyValuePair<string, string[]> materialName in materialType.Value) {
                materialColors.Add(materialName.Key.Substring(materialName.Key.LastIndexOf("/") + 1), materialName.Value);
            }
        }
        return materialColors;
    }
}

