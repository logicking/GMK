<?xml version="1.0" encoding="utf-8" standalone="yes" ?>
<!--Torque Constructor Scene document http://www.garagegames.com-->
<ConstructorScene version="4" creator="Torque Constructor" date="2009/05/25 16:22:12">
    <Sunlight azimuth="90" elevation="35" color="255 255 255" ambient="0 0 0" />
    <LightingOptions lightingSystem="" ineditor_defaultLightmapSize="256" ineditor_maxLightmapSize="256" ineditor_lightingPerformanceHint="0" ineditor_shadowPerformanceHint="1" ineditor_TAPCompatibility="0" ineditor_useSunlight="0" export_defaultLightmapSize="256" export_maxLightmapSize="256" export_lightingPerformanceHint="0" export_shadowPerformanceHint="1" export_TAPCompatibility="1" export_useSunlight="0" />
    <GameTypes>
        <GameType name="Constructor" />
        <GameType name="Torque" />
    </GameTypes>
    <SceneGroups nextGroupID="6">
        <SceneGroup id="0" />
        <SceneGroup id="1" />
        <SceneGroup id="2" />
        <SceneGroup id="3" />
        <SceneGroup id="4" />
        <SceneGroup id="5" />
    </SceneGroups>
    <DetailLevels current="0">
        <DetailLevel minPixelSize="0" actionCenter="0 0 0">
            <InteriorMap brushScale="32" lightScale="8" ambientColor="0 0 0" ambientColorEmerg="0 0 0">
                <Entities nextEntityID="1">
                    <Entity id="0" classname="worldspawn" gametype="Torque" isPointEntity="0">
                        <Properties detail_number="0" min_pixels="250" geometry_scale="32.0" light_geometry_scale="8.0" light_smoothing_scale="4.0" light_mesh_scale="1.0" ambient_color="0 0 0" emergency_ambient_color="0 0 0" mapversion="220" />
                    </Entity>
                </Entities>
                <Brushes nextBrushID="384">
                    <Brush id="8" owner="0" type="0" pos="-40 30 1.5" rot="1 0 0 0" scale="" transform="1 0 0 -40 0 1 0 30 0 0 1 1.5 0 0 0 1" group="-1" locked="0" nextFaceID="337" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 1" />
                            <Vertex pos="0.5 0.5 -1" />
                            <Vertex pos="0.5 -0.5 1" />
                            <Vertex pos="0.5 -0.5 -1" />
                            <Vertex pos="-0.5 0.5 1" />
                            <Vertex pos="-0.5 0.5 -1" />
                            <Vertex pos="-0.5 -0.5 1" />
                            <Vertex pos="-0.5 -0.5 -1" />
                        </Vertices>
                        <Face id="330" plane="1 -0 0 -0.5" album="TGEDemo" material="GRANITE_TILE_stripes" texgens="0 1 0 7551.99 0 0 -1 -128 0 0.125 0.25" texRot="0" texScale="0.125 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="331" plane="-1 0 0 -0.5" album="TGEDemo" material="GRANITE_TILE_stripes" texgens="0 -1 0 -7808.01 0 0 -1 -128 0 0.125 0.25" texRot="0" texScale="0.125 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="332" plane="0 1 -0 -0.5" album="TGEDemo" material="GRANITE_TILE_stripes" texgens="-1 0 0 10112 0 0 -1 -128 0 0.125 0.25" texRot="0" texScale="0.125 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="333" plane="0 -1 0 -0.5" album="TGEDemo" material="GRANITE_TILE_stripes" texgens="1 0 0 -10368 0 0 -1 -128 0 0.125 0.25" texRot="0" texScale="0.125 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="334" plane="-0 0 1 -1" album="TGEDemo" material="GRANITE_TILE_stripes" texgens="1 0 0 16 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="335" plane="0 0 -1 -1" album="TGEDemo" material="GRANITE_TILE_stripes" texgens="-1 0 0 16 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="13" owner="0" type="0" pos="-47.25 66 2.75" rot="1 0 0 0" scale="" transform="1 0 0 -47.25 0 0.8 0 66 0 0 1 2.75 0 0 0 1" group="-1" locked="0" nextFaceID="1933" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 5 2.25" />
                            <Vertex pos="0.25 5 -2.25" />
                            <Vertex pos="0.25 -5 2.25" />
                            <Vertex pos="0.25 -5 -2.25" />
                            <Vertex pos="-0.25 5 2.25" />
                            <Vertex pos="-0.25 5 -2.25" />
                            <Vertex pos="-0.25 -5 2.25" />
                            <Vertex pos="-0.25 -5 -2.25" />
                        </Vertices>
                        <Face id="1926" plane="1 -0 0 -0.25" album="Starter" material="cement" texgens="0 1 0 160 0 0 -1 -72 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1927" plane="-1 0 0 -0.25" album="Starter" material="cement" texgens="0 -1 0 160 0 0 -1 -72 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1928" plane="0 1 -0 -5" album="Starter" material="cement" texgens="-1 0 0 8 0 0 -1 -72 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1929" plane="0 -1 0 -5" album="Starter" material="cement" texgens="1 0 0 8 0 0 -1 -72 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1930" plane="-0 0 1 -2.25" album="Starter" material="cement" texgens="1 0 0 8 0 -1 0 -160 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1931" plane="0 0 -1 -2.25" album="Starter" material="cement" texgens="-1 0 0 8 0 -1 0 -160 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="14" owner="0" type="0" pos="-53.5 65.7921 5.25" rot="1 0 0 0" scale="" transform="0.896552 0 0 -53.5 0 0.841584 0 65.7921 0 0 1 5.25 0 0 0 1" group="-1" locked="0" nextFaceID="1645" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="7.36154 5 0.25" />
                            <Vertex pos="7.36154 5 -0.25" />
                            <Vertex pos="7.36154 -5.1 0.25" />
                            <Vertex pos="7.36154 -5.1 -0.25" />
                            <Vertex pos="-7.25 5 0.25" />
                            <Vertex pos="-7.25 5 -0.25" />
                            <Vertex pos="-7.25 -5.1 0.25" />
                            <Vertex pos="-7.25 -5.1 -0.25" />
                        </Vertices>
                        <Face id="1638" plane="1 -0 0 -7.36154" album="Starter" material="cement" texgens="0 1 0 160 0 0 -1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1639" plane="-1 0 0 -7.25" album="Starter" material="cement" texgens="0 -1 0 160 0 0 -1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1640" plane="0 1 -0 -5" album="Starter" material="cement" texgens="-1 0 0 232 0 0 -1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1641" plane="0 -1 0 -5.1" album="Starter" material="cement" texgens="1 0 0 232 0 0 -1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1642" plane="-0 0 1 -0.25" album="TGEDemo" material="granite_tile" texgens="0.999996 0 0 387.054 0 -1 0 128.001 0 1.9 1.4" texRot="0" texScale="1.9 1.4" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1643" plane="0 0 -1 -0.25" album="Starter" material="cement" texgens="-1 0 0 232 0 -1 0 -160 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="15" owner="0" type="0" pos="-48.25 62.25 2.75" rot="1 0 0 0" scale="" transform="1 0 0 -48.25 0 1 0 62.25 0 0 1 2.75 0 0 0 1" group="-1" locked="0" nextFaceID="619" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.75 0.25 2.25" />
                            <Vertex pos="0.75 0.25 -2.25" />
                            <Vertex pos="0.75 -0.25 2.25" />
                            <Vertex pos="0.75 -0.25 -2.25" />
                            <Vertex pos="-0.75 0.25 2.25" />
                            <Vertex pos="-0.75 0.25 -2.25" />
                            <Vertex pos="-0.75 -0.25 2.25" />
                            <Vertex pos="-0.75 -0.25 -2.25" />
                        </Vertices>
                        <Face id="612" plane="1 -0 0 -0.75" album="Starter" material="cement" texgens="0 1 0 8 0 0 -1 -72 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="613" plane="-1 0 0 -0.75" album="Starter" material="cement" texgens="0 -1 0 8 0 0 -1 -72 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="614" plane="0 1 -0 -0.25" album="Starter" material="cement" texgens="-1 0 0 24 0 0 -1 -72 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="615" plane="0 -1 0 -0.25" album="Starter" material="cement" texgens="1 0 0 24 0 0 -1 -72 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="616" plane="-0 0 1 -2.25" album="Starter" material="cement" texgens="1 0 0 24 0 -1 0 -8 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="617" plane="0 0 -1 -2.25" album="Starter" material="cement" texgens="-1 0 0 24 0 -1 0 -8 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="44" owner="0" type="0" pos="-30.25 70.25 5.25" rot="1 0 0 0" scale="" transform="1 0 0 -30.25 0 1 0 70.25 0 0 1 5.25 0 0 0 1" group="-1" locked="0" nextFaceID="4405" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="30.25 -0.25 -5.25" />
                            <Vertex pos="30.25 -0.25 -4.75" />
                            <Vertex pos="30.25 0.25 -4.75" />
                            <Vertex pos="30.25 0.25 -5.25" />
                            <Vertex pos="10.25 -0.25 -5.25" />
                            <Vertex pos="10.25 0.25 -5.25" />
                            <Vertex pos="10.25 0.25 -4.75" />
                            <Vertex pos="10.25 -0.25 -4.75" />
                        </Vertices>
                        <Face id="4398" plane="1 -0 0 -30.25" album="TGEDemo" material="Wall_filler1_01" texgens="0 1 0 8 0 0 -1 -168 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="4399" plane="0 0 -1 -5.25" album="TGEDemo" material="Wall_filler1_01" texgens="-1 0 0 968 0 -1 0 -8 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 4 0 3 5" />
                        </Face>
                        <Face id="4400" plane="0 1 -0 -0.25" album="TGEDemo" material="Wall_filler1_01" texgens="-1 0 0 968 0 0 -1 -168 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 2 6" />
                        </Face>
                        <Face id="4401" plane="0 -1 0 -0.25" album="TGEDemo" material="Wall_filler1_01" texgens="1 0 0 968 0 0 -1 -168 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 1 0 4 7" />
                        </Face>
                        <Face id="4402" plane="0 0 1 4.75" album="Starter" material="cement" texgens="1 0 0 312 0 -1 0 -328 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 6 2 1 7" />
                        </Face>
                        <Face id="4403" plane="-1 0 0 10.25" album="Starter" material="cement" texgens="0 1 0 328 0 0 -1 -168 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="46" owner="0" type="0" pos="-30 65.25 0.25" rot="1 0 0 0" scale="" transform="1 0 0 -30 0 1 0 65.25 0 0 1 0.25 0 0 0 1" group="-1" locked="0" nextFaceID="1261" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-10 -5.25 -0.25" />
                            <Vertex pos="-10 -5.25 0.25" />
                            <Vertex pos="10 -5.25 0.25" />
                            <Vertex pos="10 -5.25 -0.25" />
                            <Vertex pos="10 4.75 -0.0384615" />
                            <Vertex pos="10 4.75 -0.25" />
                            <Vertex pos="-10 4.75 -0.25" />
                            <Vertex pos="-10 4.75 -0.0384615" />
                        </Vertices>
                        <Face id="1254" plane="0 -1 0 -5.25" album="Starter" material="cement" texgens="1 0 0 320 0 0 -1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="1255" plane="1 0 0 -10" album="Starter" material="cement" texgens="0 1 0 168 0 0 -1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 3 2 4 5" />
                        </Face>
                        <Face id="1256" plane="-1 0 0 -10" album="Starter" material="cement" texgens="0 -1 0 168 0 0 -1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 0 6 7 1" />
                        </Face>
                        <Face id="1257" plane="-0 0.0288342 0.999584 -0.0985167" album="Starter" material="cement" texgens="1 0 0 320 0 -1 0 -168 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 1 7 4 2" />
                        </Face>
                        <Face id="1258" plane="0 0 -1 -0.25" album="Starter" material="cement" texgens="-1 0 0 320 0 -1 0 -168 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 0 3 5 6" />
                        </Face>
                        <Face id="1259" plane="0 1 0 -4.75" album="Starter" material="cement" texgens="-1 0 0 320 0 0 1 -324.8 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="54" owner="0" type="0" pos="-50.25 62.25 4.65" rot="1 0 0 0" scale="" transform="1 0 0 -50.25 0 1 0 62.25 0 0 1 4.65 0 0 0 1" group="-1" locked="0" nextFaceID="823" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.25 0.25 0.35" />
                            <Vertex pos="1.25 0.25 -0.35" />
                            <Vertex pos="1.25 -0.25 0.35" />
                            <Vertex pos="1.25 -0.25 -0.35" />
                            <Vertex pos="-1.25 0.25 0.35" />
                            <Vertex pos="-1.25 0.25 -0.35" />
                            <Vertex pos="-1.25 -0.25 0.35" />
                            <Vertex pos="-1.25 -0.25 -0.35" />
                        </Vertices>
                        <Face id="816" plane="1 -0 0 -1.25" album="Starter" material="cement" texgens="0 1 0 8 0 0 -1 -11.2 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="817" plane="-1 0 0 -1.25" album="Starter" material="cement" texgens="0 -1 0 8 0 0 -1 -11.2 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="818" plane="0 1 -0 -0.25" album="Starter" material="cement" texgens="-1 0 0 40 0 0 -1 -11.2 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="819" plane="0 -1 0 -0.25" album="Starter" material="cement" texgens="1 0 0 40 0 0 -1 -11.2 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="820" plane="-0 0 1 -0.35" album="Starter" material="cement" texgens="1 0 0 40 0 -1 0 -8 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="821" plane="0 0 -1 -0.35" album="Starter" material="cement" texgens="-1 0 0 40 0 -1 0 -8 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="59" owner="0" type="0" pos="0.25 30.25 5.25" rot="1 0 0 0" scale="" transform="1 0 0 0.25 0 1 0 30.25 0 0 1 5.25 0 0 0 1" group="-1" locked="0" nextFaceID="4393" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 -26.25 -5.25" />
                            <Vertex pos="0.25 -24.25 -5.25" />
                            <Vertex pos="-0.25 -24.25 -5.25" />
                            <Vertex pos="-0.25 -26.25 -5.25" />
                            <Vertex pos="-0.25 -24.25 -4.75" />
                            <Vertex pos="0.25 -24.25 -4.75" />
                            <Vertex pos="0.25 -26.25 -4.75" />
                            <Vertex pos="-0.25 -26.25 -4.75" />
                        </Vertices>
                        <Face id="4386" plane="-0 -0 -1 -5.25" album="TGEDemo" material="Wall_filler1_01" texgens="-1 0 0 8 0 -1 0 -968 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="4387" plane="0 1 0 24.25" album="TGEDemo" material="WalNoGroove" texgens="-1 0 0 11.2 0 0 -1 -152 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 4 2 1 5" />
                        </Face>
                        <Face id="4388" plane="1 0 -0 -0.25" album="TGEDemo" material="Wall_filler1_01" texgens="0 1 0 968 0 0 -1 -168 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 1 0 6" />
                        </Face>
                        <Face id="4389" plane="-1 0 0 -0.25" album="TGEDemo" material="Wall_filler1_01" texgens="0 -1 0 968 0 0 -1 -168 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 2 4 7" />
                        </Face>
                        <Face id="4390" plane="0 -1 0 -26.25" album="TGEDemo" material="WalNoGroove" texgens="1 0 0 27.2 0 0 -1 -152 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 0 3 7" />
                        </Face>
                        <Face id="4391" plane="-0 0 1 4.75" album="TGEDemo" material="WalNoGroove" texgens="-1 0 0 11.2 0 -1 0 -840 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="63" owner="0" type="0" pos="0.25 30.25 5.25" rot="1 0 0 0" scale="" transform="1 0 0 0.25 0 1 0 30.25 0 0 1 5.25 0 0 0 1" group="-1" locked="0" nextFaceID="4399" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 26.35 -5.25" />
                            <Vertex pos="0.25 28.35 -5.25" />
                            <Vertex pos="-0.25 28.35 -5.25" />
                            <Vertex pos="-0.25 26.35 -5.25" />
                            <Vertex pos="-0.25 28.35 -4.75" />
                            <Vertex pos="0.25 28.35 -4.75" />
                            <Vertex pos="0.25 26.35 -4.75" />
                            <Vertex pos="-0.25 26.35 -4.75" />
                        </Vertices>
                        <Face id="4392" plane="-0 -0 -1 -5.25" album="TGEDemo" material="Wall_filler1_01" texgens="-1 0 0 8 0 -1 0 -968 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="4393" plane="0 1 0 -28.35" album="TGEDemo" material="WalNoGroove" texgens="-1 0 0 11.2 0 0 -1 -152 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 4 2 1 5" />
                        </Face>
                        <Face id="4394" plane="1 0 -0 -0.25" album="TGEDemo" material="Wall_filler1_01" texgens="0 1 0 968 0 0 -1 -168 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 1 0 6" />
                        </Face>
                        <Face id="4395" plane="-1 0 0 -0.25" album="TGEDemo" material="Wall_filler1_01" texgens="0 -1 0 968 0 0 -1 -168 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 2 4 7" />
                        </Face>
                        <Face id="4396" plane="0 -1 0 26.35" album="TGEDemo" material="WalNoGroove" texgens="1 0 0 27.2 0 0 -1 -152 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 0 3 7" />
                        </Face>
                        <Face id="4397" plane="-0 0 1 4.75" album="TGEDemo" material="WalNoGroove" texgens="-1 0 0 11.2 0 -1 0 843.2 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="64" owner="0" type="0" pos="-40 10 1.5" rot="1 0 0 0" scale="" transform="1 0 0 -40 0 1 0 10 0 0 1 1.5 0 0 0 1" group="-1" locked="0" nextFaceID="337" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 1" />
                            <Vertex pos="0.5 0.5 -1" />
                            <Vertex pos="0.5 -0.5 1" />
                            <Vertex pos="0.5 -0.5 -1" />
                            <Vertex pos="-0.5 0.5 1" />
                            <Vertex pos="-0.5 0.5 -1" />
                            <Vertex pos="-0.5 -0.5 1" />
                            <Vertex pos="-0.5 -0.5 -1" />
                        </Vertices>
                        <Face id="330" plane="1 -0 0 -0.5" album="TGEDemo" material="GRANITE_TILE_stripes" texgens="0 1 0 7551.99 0 0 -1 -128 0 0.125 0.25" texRot="0" texScale="0.125 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="331" plane="-1 0 0 -0.5" album="TGEDemo" material="GRANITE_TILE_stripes" texgens="0 -1 0 -7808.01 0 0 -1 -128 0 0.125 0.25" texRot="0" texScale="0.125 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="332" plane="0 1 -0 -0.5" album="TGEDemo" material="GRANITE_TILE_stripes" texgens="-1 0 0 10112 0 0 -1 -128 0 0.125 0.25" texRot="0" texScale="0.125 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="333" plane="0 -1 0 -0.5" album="TGEDemo" material="GRANITE_TILE_stripes" texgens="1 0 0 -10368 0 0 -1 -128 0 0.125 0.25" texRot="0" texScale="0.125 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="334" plane="-0 0 1 -1" album="TGEDemo" material="GRANITE_TILE_stripes" texgens="1 0 0 16 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="335" plane="0 0 -1 -1" album="TGEDemo" material="GRANITE_TILE_stripes" texgens="-1 0 0 16 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="65" owner="0" type="0" pos="-40 50 1.5" rot="1 0 0 0" scale="" transform="1 0 0 -40 0 1 0 50 0 0 1 1.5 0 0 0 1" group="-1" locked="0" nextFaceID="337" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 1" />
                            <Vertex pos="0.5 0.5 -1" />
                            <Vertex pos="0.5 -0.5 1" />
                            <Vertex pos="0.5 -0.5 -1" />
                            <Vertex pos="-0.5 0.5 1" />
                            <Vertex pos="-0.5 0.5 -1" />
                            <Vertex pos="-0.5 -0.5 1" />
                            <Vertex pos="-0.5 -0.5 -1" />
                        </Vertices>
                        <Face id="330" plane="1 -0 0 -0.5" album="TGEDemo" material="GRANITE_TILE_stripes" texgens="0 1 0 7551.99 0 0 -1 -128 0 0.125 0.25" texRot="0" texScale="0.125 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="331" plane="-1 0 0 -0.5" album="TGEDemo" material="GRANITE_TILE_stripes" texgens="0 -1 0 -7808.01 0 0 -1 -128 0 0.125 0.25" texRot="0" texScale="0.125 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="332" plane="0 1 -0 -0.5" album="TGEDemo" material="GRANITE_TILE_stripes" texgens="-1 0 0 10112 0 0 -1 -128 0 0.125 0.25" texRot="0" texScale="0.125 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="333" plane="0 -1 0 -0.5" album="TGEDemo" material="GRANITE_TILE_stripes" texgens="1 0 0 -10368 0 0 -1 -128 0 0.125 0.25" texRot="0" texScale="0.125 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="334" plane="-0 0 1 -1" album="TGEDemo" material="GRANITE_TILE_stripes" texgens="1 0 0 16 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="335" plane="0 0 -1 -1" album="TGEDemo" material="GRANITE_TILE_stripes" texgens="-1 0 0 16 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="66" owner="0" type="0" pos="-20 30 1.5" rot="1 0 0 0" scale="" transform="1 0 0 -20 0 1 0 30 0 0 1 1.5 0 0 0 1" group="-1" locked="0" nextFaceID="337" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 1" />
                            <Vertex pos="0.5 0.5 -1" />
                            <Vertex pos="0.5 -0.5 1" />
                            <Vertex pos="0.5 -0.5 -1" />
                            <Vertex pos="-0.5 0.5 1" />
                            <Vertex pos="-0.5 0.5 -1" />
                            <Vertex pos="-0.5 -0.5 1" />
                            <Vertex pos="-0.5 -0.5 -1" />
                        </Vertices>
                        <Face id="330" plane="1 -0 0 -0.5" album="TGEDemo" material="GRANITE_TILE_stripes" texgens="0 1 0 7551.99 0 0 -1 -128 0 0.125 0.25" texRot="0" texScale="0.125 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="331" plane="-1 0 0 -0.5" album="TGEDemo" material="GRANITE_TILE_stripes" texgens="0 -1 0 -7808.01 0 0 -1 -128 0 0.125 0.25" texRot="0" texScale="0.125 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="332" plane="0 1 -0 -0.5" album="TGEDemo" material="GRANITE_TILE_stripes" texgens="-1 0 0 10112 0 0 -1 -128 0 0.125 0.25" texRot="0" texScale="0.125 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="333" plane="0 -1 0 -0.5" album="TGEDemo" material="GRANITE_TILE_stripes" texgens="1 0 0 -10368 0 0 -1 -128 0 0.125 0.25" texRot="0" texScale="0.125 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="334" plane="-0 0 1 -1" album="TGEDemo" material="GRANITE_TILE_stripes" texgens="1 0 0 16 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="335" plane="0 0 -1 -1" album="TGEDemo" material="GRANITE_TILE_stripes" texgens="-1 0 0 16 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="67" owner="0" type="0" pos="-20 10 1.5" rot="1 0 0 0" scale="" transform="1 0 0 -20 0 1 0 10 0 0 1 1.5 0 0 0 1" group="-1" locked="0" nextFaceID="337" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 1" />
                            <Vertex pos="0.5 0.5 -1" />
                            <Vertex pos="0.5 -0.5 1" />
                            <Vertex pos="0.5 -0.5 -1" />
                            <Vertex pos="-0.5 0.5 1" />
                            <Vertex pos="-0.5 0.5 -1" />
                            <Vertex pos="-0.5 -0.5 1" />
                            <Vertex pos="-0.5 -0.5 -1" />
                        </Vertices>
                        <Face id="330" plane="1 -0 0 -0.5" album="TGEDemo" material="GRANITE_TILE_stripes" texgens="0 1 0 7551.99 0 0 -1 -128 0 0.125 0.25" texRot="0" texScale="0.125 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="331" plane="-1 0 0 -0.5" album="TGEDemo" material="GRANITE_TILE_stripes" texgens="0 -1 0 -7808.01 0 0 -1 -128 0 0.125 0.25" texRot="0" texScale="0.125 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="332" plane="0 1 -0 -0.5" album="TGEDemo" material="GRANITE_TILE_stripes" texgens="-1 0 0 10112 0 0 -1 -128 0 0.125 0.25" texRot="0" texScale="0.125 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="333" plane="0 -1 0 -0.5" album="TGEDemo" material="GRANITE_TILE_stripes" texgens="1 0 0 -10368 0 0 -1 -128 0 0.125 0.25" texRot="0" texScale="0.125 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="334" plane="-0 0 1 -1" album="TGEDemo" material="GRANITE_TILE_stripes" texgens="1 0 0 16 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="335" plane="0 0 -1 -1" album="TGEDemo" material="GRANITE_TILE_stripes" texgens="-1 0 0 16 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="68" owner="0" type="0" pos="-20 50 1.5" rot="1 0 0 0" scale="" transform="1 0 0 -20 0 1 0 50 0 0 1 1.5 0 0 0 1" group="-1" locked="0" nextFaceID="337" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 1" />
                            <Vertex pos="0.5 0.5 -1" />
                            <Vertex pos="0.5 -0.5 1" />
                            <Vertex pos="0.5 -0.5 -1" />
                            <Vertex pos="-0.5 0.5 1" />
                            <Vertex pos="-0.5 0.5 -1" />
                            <Vertex pos="-0.5 -0.5 1" />
                            <Vertex pos="-0.5 -0.5 -1" />
                        </Vertices>
                        <Face id="330" plane="1 -0 0 -0.5" album="TGEDemo" material="GRANITE_TILE_stripes" texgens="0 1 0 7551.99 0 0 -1 -128 0 0.125 0.25" texRot="0" texScale="0.125 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="331" plane="-1 0 0 -0.5" album="TGEDemo" material="GRANITE_TILE_stripes" texgens="0 -1 0 -7808.01 0 0 -1 -128 0 0.125 0.25" texRot="0" texScale="0.125 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="332" plane="0 1 -0 -0.5" album="TGEDemo" material="GRANITE_TILE_stripes" texgens="-1 0 0 10112 0 0 -1 -128 0 0.125 0.25" texRot="0" texScale="0.125 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="333" plane="0 -1 0 -0.5" album="TGEDemo" material="GRANITE_TILE_stripes" texgens="1 0 0 -10368 0 0 -1 -128 0 0.125 0.25" texRot="0" texScale="0.125 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="334" plane="-0 0 1 -1" album="TGEDemo" material="GRANITE_TILE_stripes" texgens="1 0 0 16 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="335" plane="0 0 -1 -1" album="TGEDemo" material="GRANITE_TILE_stripes" texgens="-1 0 0 16 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="82" owner="0" type="0" pos="-30 30 0.25" rot="1 0 0 0" scale="" transform="1 0 0 -30 0 1 0 30 0 0 1 0.25 0 0 0 1" group="-1" locked="0" nextFaceID="1015" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-10 -30 -0.25" />
                            <Vertex pos="-10 -20 -0.25" />
                            <Vertex pos="-10 -20 0.25" />
                            <Vertex pos="-10 -30 0.25" />
                            <Vertex pos="10 -30 0.25" />
                            <Vertex pos="10 -30 -0.25" />
                            <Vertex pos="10 -20 0.25" />
                            <Vertex pos="10 -20 -0.25" />
                        </Vertices>
                        <Face id="1008" plane="-1 0 0 -10" album="TGEDemo" material="asfalt_001" texgens="0 -1 0 1296 0 0 -1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="1009" plane="-0 -1 -0 -30" album="TGEDemo" material="asfalt_001" texgens="1 0 0 960 0 0 -1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 4 5 0" />
                        </Face>
                        <Face id="1010" plane="0 0 1 -0.25" album="TGEDemo" material="asfalt_001" texgens="1 0 0 1264 0 -1 0 2704 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 4 3 2 6" />
                        </Face>
                        <Face id="1011" plane="0 0 -1 -0.25" album="TGEDemo" material="asfalt_001" texgens="-1 0 0 960 0 -1 0 -960 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 0 5 7 1" />
                        </Face>
                        <Face id="1012" plane="0 1 -0 20" album="TGEDemo" material="asfalt_001" texgens="1 0 0 960 0 0 1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 1 7 6 2" />
                        </Face>
                        <Face id="1013" plane="1 0 0 -10" album="TGEDemo" material="asfalt_001" texgens="0 -1 0 960 0 0 1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="84" owner="0" type="0" pos="-30 30 0.25" rot="1 0 0 0" scale="" transform="1 0 0 -30 0 1 0 30 0 0 1 0.25 0 0 0 1" group="-1" locked="0" nextFaceID="1021" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-10 -20 -0.25" />
                            <Vertex pos="-10 -1.19209e-006 -0.25" />
                            <Vertex pos="-10 -2.98023e-007 0.25" />
                            <Vertex pos="-10 -20 0.25" />
                            <Vertex pos="10 -20 0.25" />
                            <Vertex pos="10 -20 -0.25" />
                            <Vertex pos="10 -2.98023e-007 0.25" />
                            <Vertex pos="10 -1.19209e-006 -0.25" />
                        </Vertices>
                        <Face id="1014" plane="-1 0 0 -10" album="TGEDemo" material="asfalt_001" texgens="0 -1 0 1296 0 0 -1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="1015" plane="0 -1 0 -20" album="TGEDemo" material="asfalt_001" texgens="1 0 0 960 0 0 1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 0 3 4 5" />
                        </Face>
                        <Face id="1016" plane="0 0 1 -0.25" album="TGEDemo" material="asfalt_001" texgens="1 0 0 1264 0 -1 0 2704 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 4 3 2 6" />
                        </Face>
                        <Face id="1017" plane="0 0 -1 -0.25" album="TGEDemo" material="asfalt_001" texgens="-1 0 0 960 0 -1 0 -960 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 1 0 5" />
                        </Face>
                        <Face id="1018" plane="0 1 -1.78813e-006 7.45057e-007" album="TGEDemo" material="asfalt_001" texgens="1 0 0 960 0 0 1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 1 7 6 2" />
                        </Face>
                        <Face id="1019" plane="1 0 0 -10" album="TGEDemo" material="asfalt_001" texgens="0 -1 0 960 0 0 1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="86" owner="0" type="0" pos="-30 30 0.25" rot="1 0 0 0" scale="" transform="1 0 0 -30 0 1 0 30 0 0 1 0.25 0 0 0 1" group="-1" locked="0" nextFaceID="1027" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-10 -1.19209e-006 -0.25" />
                            <Vertex pos="-10 20 -0.25" />
                            <Vertex pos="-10 20 0.25" />
                            <Vertex pos="-10 -2.98023e-007 0.25" />
                            <Vertex pos="10 -2.98023e-007 0.25" />
                            <Vertex pos="10 -1.19209e-006 -0.25" />
                            <Vertex pos="10 20 0.25" />
                            <Vertex pos="10 20 -0.25" />
                        </Vertices>
                        <Face id="1020" plane="-1 0 0 -10" album="TGEDemo" material="asfalt_001" texgens="0 -1 0 1296 0 0 -1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="1021" plane="0 -1 1.78813e-006 -7.45057e-007" album="TGEDemo" material="asfalt_001" texgens="1 0 0 960 0 0 1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 0 3 4 5" />
                        </Face>
                        <Face id="1022" plane="0 0 1 -0.25" album="TGEDemo" material="asfalt_001" texgens="1 0 0 1264 0 -1 0 2704 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 4 3 2 6" />
                        </Face>
                        <Face id="1023" plane="0 0 -1 -0.25" album="TGEDemo" material="asfalt_001" texgens="-1 0 0 960 0 -1 0 -960 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 1 0 5" />
                        </Face>
                        <Face id="1024" plane="0 1 -0 -20" album="TGEDemo" material="asfalt_001" texgens="1 0 0 960 0 0 1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 1 7 6 2" />
                        </Face>
                        <Face id="1025" plane="1 0 0 -10" album="TGEDemo" material="asfalt_001" texgens="0 -1 0 960 0 0 1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="88" owner="0" type="0" pos="-30 30 0.25" rot="1 0 0 0" scale="" transform="1 0 0 -30 0 1 0 30 0 0 1 0.25 0 0 0 1" group="-1" locked="0" nextFaceID="1027" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-10 20 -0.25" />
                            <Vertex pos="-10 30 -0.25" />
                            <Vertex pos="-10 30 0.25" />
                            <Vertex pos="-10 20 0.25" />
                            <Vertex pos="10 30 -0.25" />
                            <Vertex pos="10 30 0.25" />
                            <Vertex pos="10 20 0.25" />
                            <Vertex pos="10 20 -0.25" />
                        </Vertices>
                        <Face id="1020" plane="-1 0 0 -10" album="TGEDemo" material="asfalt_001" texgens="0 -1 0 1296 0 0 -1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="1021" plane="0 1 -0 -30" album="TGEDemo" material="asfalt_001" texgens="1 0 0 320 0 0 -1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="1022" plane="0 0 1 -0.25" album="TGEDemo" material="asfalt_001" texgens="1 0 0 1264 0 -1 0 2704 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 3 2 5" />
                        </Face>
                        <Face id="1023" plane="0 0 -1 -0.25" album="TGEDemo" material="asfalt_001" texgens="-1 0 0 960 0 -1 0 -960 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 4 1 0 7" />
                        </Face>
                        <Face id="1024" plane="0 -1 0 20" album="TGEDemo" material="asfalt_001" texgens="1 0 0 960 0 0 1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 0 3 6 7" />
                        </Face>
                        <Face id="1025" plane="1 -0 0 -10" album="TGEDemo" material="asfalt_001" texgens="0 -1 0 320 0 0 1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="91" owner="0" type="0" pos="-30 30 0.25" rot="1 0 0 0" scale="" transform="1 0 0 -30 0 1 0 30 0 0 1 0.25 0 0 0 1" group="-1" locked="0" nextFaceID="1009" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-10 -30 -0.25" />
                            <Vertex pos="-10 -30 0.25" />
                            <Vertex pos="-10 -20 0.25" />
                            <Vertex pos="-10 -20 -0.25" />
                            <Vertex pos="-12 -30 0.25" />
                            <Vertex pos="-12 -30 -0.25" />
                            <Vertex pos="-12 -20 0.25" />
                            <Vertex pos="-12 -20 -0.25" />
                        </Vertices>
                        <Face id="1002" plane="1 -0 0 10" album="TGEDemo" material="asfalt_add_001" texgens="0 -1 0 1296 0 0 -1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="1003" plane="-0 -1 -0 -30" album="TGEDemo" material="asfalt_add_001" texgens="1 0 0 960 0 0 -1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 4 1 0 5" />
                        </Face>
                        <Face id="1004" plane="0 0 1 -0.25" album="TGEDemo" material="asfalt_add_001" texgens="-1 0 0 1264 0 -1 0 2704 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 2 1 4" />
                        </Face>
                        <Face id="1005" plane="0 0 -1 -0.25" album="TGEDemo" material="asfalt_add_001" texgens="-1 0 0 960 0 -1 0 -960 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 0 3 7" />
                        </Face>
                        <Face id="1006" plane="0 1 0 20" album="TGEDemo" material="asfalt_add_001" texgens="1 0 0 960 0 0 1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 2 6 7" />
                        </Face>
                        <Face id="1007" plane="-1 -0 -0 -12" album="TGEDemo" material="asfalt_add_001" texgens="0 -1 0 960 0 0 1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="93" owner="0" type="0" pos="-30 30 0.25" rot="1 0 0 0" scale="" transform="1 0 0 -30 0 1 0 30 0 0 1 0.25 0 0 0 1" group="-1" locked="0" nextFaceID="1015" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-10 -20 0.25" />
                            <Vertex pos="-10 -3.8743e-007 0.25" />
                            <Vertex pos="-10 -3.8743e-007 -0.25" />
                            <Vertex pos="-10 -20 -0.25" />
                            <Vertex pos="-12 -20 -0.25" />
                            <Vertex pos="-12 -20 0.25" />
                            <Vertex pos="-12 -3.8743e-007 0.25" />
                            <Vertex pos="-12 -3.8743e-007 -0.25" />
                        </Vertices>
                        <Face id="1008" plane="1 0 0 10" album="TGEDemo" material="asfalt_add_001" texgens="0 -1 0 1296 0 0 -1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="1009" plane="0 -1 0 -20" album="TGEDemo" material="asfalt_add_001" texgens="1 0 0 960 0 0 1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 4 5 0" />
                        </Face>
                        <Face id="1010" plane="0 0 1 -0.25" album="TGEDemo" material="asfalt_add_001" texgens="-1 0 0 1264 0 -1 0 2704 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 1 0 5" />
                        </Face>
                        <Face id="1011" plane="-0 -0 -1 -0.25" album="TGEDemo" material="asfalt_add_001" texgens="-1 0 0 960 0 -1 0 -960 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 2 7 4" />
                        </Face>
                        <Face id="1012" plane="0 1 0 3.8743e-007" album="TGEDemo" material="asfalt_add_001" texgens="1 0 0 960 0 0 1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 2 1 6 7" />
                        </Face>
                        <Face id="1013" plane="-1 -0 -0 -12" album="TGEDemo" material="asfalt_add_001" texgens="0 -1 0 960 0 0 1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="95" owner="0" type="0" pos="-30 30 0.25" rot="1 0 0 0" scale="" transform="1 0 0 -30 0 1 0 30 0 0 1 0.25 0 0 0 1" group="-1" locked="0" nextFaceID="1021" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-10 -3.8743e-007 0.25" />
                            <Vertex pos="-10 20 0.25" />
                            <Vertex pos="-10 20 -0.25" />
                            <Vertex pos="-10 -3.8743e-007 -0.25" />
                            <Vertex pos="-12 -3.8743e-007 -0.25" />
                            <Vertex pos="-12 -3.8743e-007 0.25" />
                            <Vertex pos="-12 20 0.25" />
                            <Vertex pos="-12 20 -0.25" />
                        </Vertices>
                        <Face id="1014" plane="1 0 0 10" album="TGEDemo" material="asfalt_add_001" texgens="0 -1 0 1296 0 0 -1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="1015" plane="0 -1 0 -3.8743e-007" album="TGEDemo" material="asfalt_add_001" texgens="1 0 0 960 0 0 1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 4 5 0" />
                        </Face>
                        <Face id="1016" plane="0 0 1 -0.25" album="TGEDemo" material="asfalt_add_001" texgens="-1 0 0 1264 0 -1 0 2704 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 1 0 5" />
                        </Face>
                        <Face id="1017" plane="-0 -0 -1 -0.25" album="TGEDemo" material="asfalt_add_001" texgens="-1 0 0 960 0 -1 0 -960 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 2 7 4" />
                        </Face>
                        <Face id="1018" plane="0 1 0 -20" album="TGEDemo" material="asfalt_add_001" texgens="1 0 0 960 0 0 1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 2 1 6 7" />
                        </Face>
                        <Face id="1019" plane="-1 -0 -0 -12" album="TGEDemo" material="asfalt_add_001" texgens="0 -1 0 960 0 0 1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="96" owner="0" type="0" pos="-30 30 0.25" rot="1 0 0 0" scale="" transform="1 0 0 -30 0 1 0 30 0 0 1 0.25 0 0 0 1" group="-1" locked="0" nextFaceID="1021" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-30 20 -0.25" />
                            <Vertex pos="-30 40.5 -0.25" />
                            <Vertex pos="-30 40.5 0.25" />
                            <Vertex pos="-30 20 0.25" />
                            <Vertex pos="-12 40.5 -0.25" />
                            <Vertex pos="-12 40.5 0.25" />
                            <Vertex pos="-12 20 0.25" />
                            <Vertex pos="-12 20 -0.25" />
                        </Vertices>
                        <Face id="1014" plane="-1 0 0 -30" album="TGEDemo" material="asfalt_001" texgens="0 -1 0 960 0 0 -1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="1015" plane="0 1 -0 -40.5" album="TGEDemo" material="asfalt_001" texgens="-1 0 0 960 0 0 -1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="1016" plane="-0 0 1 -0.25" album="TGEDemo" material="asfalt_001" texgens="1 0 0 1264 0 -1 0 2704 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 5 6" />
                        </Face>
                        <Face id="1017" plane="0 0 -1 -0.25" album="TGEDemo" material="asfalt_001" texgens="-1 0 0 960 0 -1 0 -960 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 4 1 0 7" />
                        </Face>
                        <Face id="1018" plane="0 -1 0 20" album="TGEDemo" material="asfalt_001" texgens="1 0 0 960 0 0 1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 0 3 6" />
                        </Face>
                        <Face id="1019" plane="1 -0 0 12" album="TGEDemo" material="asfalt_001" texgens="0 -1 0 960 0 0 1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="97" owner="0" type="0" pos="-30 30 0.25" rot="1 0 0 0" scale="" transform="1 0 0 -30 0 1 0 30 0 0 1 0.25 0 0 0 1" group="-1" locked="0" nextFaceID="1021" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-10 20 0.25" />
                            <Vertex pos="-10 40.5 0.25" />
                            <Vertex pos="-10 40.5 -0.25" />
                            <Vertex pos="-10 20 -0.25" />
                            <Vertex pos="-12 40.5 -0.25" />
                            <Vertex pos="-12 40.5 0.25" />
                            <Vertex pos="-12 20 0.25" />
                            <Vertex pos="-12 20 -0.25" />
                        </Vertices>
                        <Face id="1014" plane="1 0 0 10" album="TGEDemo" material="asfalt_add_001" texgens="0 -1 0 1296 0 0 -1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="1015" plane="0 1 -0 -40.5" album="TGEDemo" material="asfalt_add_001" texgens="-1 0 0 960 0 0 -1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 4 2 1 5" />
                        </Face>
                        <Face id="1016" plane="0 0 1 -0.25" album="TGEDemo" material="asfalt_add_001" texgens="-1 0 0 1264 0 -1 0 2704 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 6" />
                        </Face>
                        <Face id="1017" plane="-0 -0 -1 -0.25" album="TGEDemo" material="asfalt_add_001" texgens="-1 0 0 960 0 -1 0 -960 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 2 4 7" />
                        </Face>
                        <Face id="1018" plane="0 -1 0 20" album="TGEDemo" material="asfalt_add_001" texgens="1 0 0 960 0 0 1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 7 6 0" />
                        </Face>
                        <Face id="1019" plane="-1 0 0 -12" album="TGEDemo" material="asfalt_add_001" texgens="0 -1 0 960 0 0 1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="98" owner="0" type="0" pos="-30 30 0.25" rot="1 0 0 0" scale="" transform="1 0 0 -30 0 1 0 30 0 0 1 0.25 0 0 0 1" group="-1" locked="0" nextFaceID="1015" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="10 30 -0.25" />
                            <Vertex pos="10 40.5 -0.25" />
                            <Vertex pos="10 40.5 0.25" />
                            <Vertex pos="10 30 0.25" />
                            <Vertex pos="12 40.5 -0.25" />
                            <Vertex pos="12 40.5 0.25" />
                            <Vertex pos="12 30 0.25" />
                            <Vertex pos="12 30 -0.25" />
                        </Vertices>
                        <Face id="1008" plane="-1 0 0 10" album="TGEDemo" material="asfalt_add_001" texgens="0 1 0 -960 0 0 -1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="1009" plane="0 1 -0 -40.5" album="TGEDemo" material="asfalt_add_001" texgens="-1 0 0 960 0 0 -1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="1010" plane="0 0 1 -0.25" album="TGEDemo" material="asfalt_add_001" texgens="1 0 0 1264 0 -1 0 2704 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 2 5 6 3" />
                        </Face>
                        <Face id="1011" plane="0 0 -1 -0.25" album="TGEDemo" material="asfalt_add_001" texgens="-1 0 0 960 0 -1 0 -960 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 4 1 0 7" />
                        </Face>
                        <Face id="1012" plane="-0 -1 -0 30" album="TGEDemo" material="asfalt_add_001" texgens="1 0 0 320 0 0 -1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 6 7 0" />
                        </Face>
                        <Face id="1013" plane="1 -0 0 -12" album="TGEDemo" material="asfalt_add_001" texgens="0 -1 0 960 0 0 1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="99" owner="0" type="0" pos="-30 30 0.25" rot="1 0 0 0" scale="" transform="1 0 0 -30 0 1 0 30 0 0 1 0.25 0 0 0 1" group="-1" locked="0" nextFaceID="1015" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="30 30 0.25" />
                            <Vertex pos="30 40.5 0.25" />
                            <Vertex pos="30 40.5 -0.25" />
                            <Vertex pos="30 30 -0.25" />
                            <Vertex pos="12 40.5 -0.25" />
                            <Vertex pos="12 40.5 0.25" />
                            <Vertex pos="12 30 0.25" />
                            <Vertex pos="12 30 -0.25" />
                        </Vertices>
                        <Face id="1008" plane="1 0 0 -30" album="TGEDemo" material="asfalt_001" texgens="0 1 0 960 0 0 -1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="1009" plane="0 1 -0 -40.5" album="TGEDemo" material="asfalt_001" texgens="-1 0 0 960 0 0 -1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 4 2 1 5" />
                        </Face>
                        <Face id="1010" plane="0 0 1 -0.25" album="TGEDemo" material="asfalt_001" texgens="1 0 0 1264 0 -1 0 2704 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 6" />
                        </Face>
                        <Face id="1011" plane="-0 -0 -1 -0.25" album="TGEDemo" material="asfalt_001" texgens="-1 0 0 960 0 -1 0 -960 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 2 4 7" />
                        </Face>
                        <Face id="1012" plane="-0 -1 -0 30" album="TGEDemo" material="asfalt_001" texgens="1 0 0 320 0 0 -1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 0 3 7" />
                        </Face>
                        <Face id="1013" plane="-1 0 0 12" album="TGEDemo" material="asfalt_001" texgens="0 -1 0 960 0 0 1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="100" owner="0" type="0" pos="-30 30 0.25" rot="1 0 0 0" scale="" transform="1 0 0 -30 0 1 0 30 0 0 1 0.25 0 0 0 1" group="-1" locked="0" nextFaceID="1021" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="10 -20 -0.25" />
                            <Vertex pos="10 -20 0.25" />
                            <Vertex pos="10 -30 0.25" />
                            <Vertex pos="10 -30 -0.25" />
                            <Vertex pos="12 -30 0.25" />
                            <Vertex pos="12 -30 -0.25" />
                            <Vertex pos="12 -20 0.25" />
                            <Vertex pos="12 -20 -0.25" />
                        </Vertices>
                        <Face id="1014" plane="-1 -0 -0 10" album="TGEDemo" material="asfalt_add_001" texgens="0 -1 0 960 0 0 1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="1015" plane="-0 -1 -0 -30" album="TGEDemo" material="asfalt_add_001" texgens="1 0 0 960 0 0 -1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 2 4 5 3" />
                        </Face>
                        <Face id="1016" plane="0 0 1 -0.25" album="TGEDemo" material="asfalt_add_001" texgens="1 0 0 1264 0 -1 0 2704 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 4 2 1 6" />
                        </Face>
                        <Face id="1017" plane="0 0 -1 -0.25" album="TGEDemo" material="asfalt_add_001" texgens="-1 0 0 960 0 -1 0 -960 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 5 7 0" />
                        </Face>
                        <Face id="1018" plane="0 1 -0 20" album="TGEDemo" material="asfalt_add_001" texgens="1 0 0 960 0 0 1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 0 7 6 1" />
                        </Face>
                        <Face id="1019" plane="1 0 0 -12" album="TGEDemo" material="asfalt_add_001" texgens="0 -1 0 960 0 0 1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="101" owner="0" type="0" pos="-30 30 0.25" rot="1 0 0 0" scale="" transform="1 0 0 -30 0 1 0 30 0 0 1 0.25 0 0 0 1" group="-1" locked="0" nextFaceID="1021" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="30 -30 -0.25" />
                            <Vertex pos="30 -30 0.25" />
                            <Vertex pos="30 -20 0.25" />
                            <Vertex pos="30 -20 -0.25" />
                            <Vertex pos="12 -30 0.25" />
                            <Vertex pos="12 -30 -0.25" />
                            <Vertex pos="12 -20 0.25" />
                            <Vertex pos="12 -20 -0.25" />
                        </Vertices>
                        <Face id="1014" plane="1 -0 0 -30" album="TGEDemo" material="asfalt_001" texgens="0 1 0 960 0 0 -1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="1015" plane="-0 -1 -0 -30" album="TGEDemo" material="asfalt_001" texgens="1 0 0 960 0 0 -1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 4 1 0 5" />
                        </Face>
                        <Face id="1016" plane="0 -0 1 -0.25" album="TGEDemo" material="asfalt_001" texgens="1 0 0 1264 0 -1 0 2704 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 2 1 4 6" />
                        </Face>
                        <Face id="1017" plane="0 0 -1 -0.25" album="TGEDemo" material="asfalt_001" texgens="-1 0 0 960 0 -1 0 -960 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 0 3 7" />
                        </Face>
                        <Face id="1018" plane="0 1 -0 20" album="TGEDemo" material="asfalt_001" texgens="1 0 0 960 0 0 1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="1019" plane="-1 -0 -0 12" album="TGEDemo" material="asfalt_001" texgens="0 -1 0 960 0 0 1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="102" owner="0" type="0" pos="-30 30 0.25" rot="1 0 0 0" scale="" transform="1 0 0 -30 0 1 0 30 0 0 1 0.25 0 0 0 1" group="-1" locked="0" nextFaceID="1027" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="10 -1.19209e-006 -0.25" />
                            <Vertex pos="10 -2.98023e-007 0.25" />
                            <Vertex pos="10 -20 0.25" />
                            <Vertex pos="10 -20 -0.25" />
                            <Vertex pos="12 -20 0.25" />
                            <Vertex pos="12 -20 -0.25" />
                            <Vertex pos="12 -2.98023e-007 0.25" />
                            <Vertex pos="12 -1.19209e-006 -0.25" />
                        </Vertices>
                        <Face id="1020" plane="-1 -0 0 10" album="TGEDemo" material="asfalt_add_001" texgens="0 -1 0 960 0 0 1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="1021" plane="-0 -1 -0 -20" album="TGEDemo" material="asfalt_add_001" texgens="1 0 0 960 0 0 1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 2 4 5 3" />
                        </Face>
                        <Face id="1022" plane="0 0 1 -0.25" album="TGEDemo" material="asfalt_add_001" texgens="1 0 0 1264 0 -1 0 2704 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 4 2 1 6" />
                        </Face>
                        <Face id="1023" plane="0 0 -1 -0.25" album="TGEDemo" material="asfalt_add_001" texgens="-1 0 0 960 0 -1 0 -960 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 0 3 5" />
                        </Face>
                        <Face id="1024" plane="0 1 -1.78813e-006 7.45057e-007" album="TGEDemo" material="asfalt_add_001" texgens="1 0 0 960 0 0 1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 0 7 6 1" />
                        </Face>
                        <Face id="1025" plane="1 0 0 -12" album="TGEDemo" material="asfalt_add_001" texgens="0 -1 0 960 0 0 1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="103" owner="0" type="0" pos="-30 30 0.25" rot="1 0 0 0" scale="" transform="1 0 0 -30 0 1 0 30 0 0 1 0.25 0 0 0 1" group="-1" locked="0" nextFaceID="1027" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="30 -20 0.25" />
                            <Vertex pos="30 -2.98023e-007 0.25" />
                            <Vertex pos="30 -1.19209e-006 -0.25" />
                            <Vertex pos="30 -20 -0.25" />
                            <Vertex pos="12 -20 0.25" />
                            <Vertex pos="12 -20 -0.25" />
                            <Vertex pos="12 -2.98023e-007 0.25" />
                            <Vertex pos="12 -1.19209e-006 -0.25" />
                        </Vertices>
                        <Face id="1020" plane="1 0 0 -30" album="TGEDemo" material="asfalt_001" texgens="0 1 0 960 0 0 -1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="1021" plane="-0 -1 -0 -20" album="TGEDemo" material="asfalt_001" texgens="1 0 0 960 0 0 1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 4 0 3 5" />
                        </Face>
                        <Face id="1022" plane="0 -0 1 -0.25" album="TGEDemo" material="asfalt_001" texgens="1 0 0 1264 0 -1 0 2704 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 1 0 4 6" />
                        </Face>
                        <Face id="1023" plane="-0 -0 -1 -0.25" album="TGEDemo" material="asfalt_001" texgens="-1 0 0 960 0 -1 0 -960 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 2 7 5" />
                        </Face>
                        <Face id="1024" plane="0 1 -1.78813e-006 7.45057e-007" album="TGEDemo" material="asfalt_001" texgens="1 0 0 960 0 0 1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 2 1 6" />
                        </Face>
                        <Face id="1025" plane="-1 -0 0 12" album="TGEDemo" material="asfalt_001" texgens="0 -1 0 960 0 0 1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="104" owner="0" type="0" pos="-30 30 0.25" rot="1 0 0 0" scale="" transform="1 0 0 -30 0 1 0 30 0 0 1 0.25 0 0 0 1" group="-1" locked="0" nextFaceID="1033" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="10 20 -0.25" />
                            <Vertex pos="10 20 0.25" />
                            <Vertex pos="10 -2.98023e-007 0.25" />
                            <Vertex pos="10 -1.19209e-006 -0.25" />
                            <Vertex pos="12 -2.98023e-007 0.25" />
                            <Vertex pos="12 -1.19209e-006 -0.25" />
                            <Vertex pos="12 20 0.25" />
                            <Vertex pos="12 20 -0.25" />
                        </Vertices>
                        <Face id="1026" plane="-1 -0 -0 10" album="TGEDemo" material="asfalt_add_001" texgens="0 -1 0 960 0 0 1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="1027" plane="0 -1 1.78813e-006 -7.45057e-007" album="TGEDemo" material="asfalt_add_001" texgens="1 0 0 960 0 0 1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 2 4 5 3" />
                        </Face>
                        <Face id="1028" plane="0 0 1 -0.25" album="TGEDemo" material="asfalt_add_001" texgens="1 0 0 1264 0 -1 0 2704 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 4 2 1 6" />
                        </Face>
                        <Face id="1029" plane="0 0 -1 -0.25" album="TGEDemo" material="asfalt_add_001" texgens="-1 0 0 960 0 -1 0 -960 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 0 3 5" />
                        </Face>
                        <Face id="1030" plane="0 1 -0 -20" album="TGEDemo" material="asfalt_add_001" texgens="1 0 0 960 0 0 1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 0 7 6 1" />
                        </Face>
                        <Face id="1031" plane="1 0 0 -12" album="TGEDemo" material="asfalt_add_001" texgens="0 -1 0 960 0 0 1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="105" owner="0" type="0" pos="-30 30 0.25" rot="1 0 0 0" scale="" transform="1 0 0 -30 0 1 0 30 0 0 1 0.25 0 0 0 1" group="-1" locked="0" nextFaceID="1033" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="30 -2.98023e-007 0.25" />
                            <Vertex pos="30 20 0.25" />
                            <Vertex pos="30 20 -0.25" />
                            <Vertex pos="30 -1.19209e-006 -0.25" />
                            <Vertex pos="12 -2.98023e-007 0.25" />
                            <Vertex pos="12 -1.19209e-006 -0.25" />
                            <Vertex pos="12 20 0.25" />
                            <Vertex pos="12 20 -0.25" />
                        </Vertices>
                        <Face id="1026" plane="1 0 0 -30" album="TGEDemo" material="asfalt_001" texgens="0 1 0 960 0 0 -1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="1027" plane="0 -1 1.78813e-006 -7.45057e-007" album="TGEDemo" material="asfalt_001" texgens="1 0 0 960 0 0 1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 4 0 3 5" />
                        </Face>
                        <Face id="1028" plane="0 -0 1 -0.25" album="TGEDemo" material="asfalt_001" texgens="1 0 0 1264 0 -1 0 2704 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 1 0 4 6" />
                        </Face>
                        <Face id="1029" plane="-0 -0 -1 -0.25" album="TGEDemo" material="asfalt_001" texgens="-1 0 0 960 0 -1 0 -960 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 2 7 5" />
                        </Face>
                        <Face id="1030" plane="0 1 -0 -20" album="TGEDemo" material="asfalt_001" texgens="1 0 0 960 0 0 1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 2 1 6" />
                        </Face>
                        <Face id="1031" plane="-1 -0 -0 12" album="TGEDemo" material="asfalt_001" texgens="0 -1 0 960 0 0 1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="106" owner="0" type="0" pos="-30 30 0.25" rot="1 0 0 0" scale="" transform="1 0 0 -30 0 1 0 30 0 0 1 0.25 0 0 0 1" group="-1" locked="0" nextFaceID="1033" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="10 20 -0.25" />
                            <Vertex pos="10 30 -0.25" />
                            <Vertex pos="10 30 0.25" />
                            <Vertex pos="10 20 0.25" />
                            <Vertex pos="12 30 -0.25" />
                            <Vertex pos="12 30 0.25" />
                            <Vertex pos="12 20 0.25" />
                            <Vertex pos="12 20 -0.25" />
                        </Vertices>
                        <Face id="1026" plane="-1 0 0 10" album="TGEDemo" material="asfalt_add_001" texgens="0 -1 0 320 0 0 1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="1027" plane="0 1 -0 -30" album="TGEDemo" material="asfalt_add_001" texgens="1 0 0 320 0 0 -1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="1028" plane="0 0 1 -0.25" album="TGEDemo" material="asfalt_add_001" texgens="1 0 0 1264 0 -1 0 2704 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 3 2 5" />
                        </Face>
                        <Face id="1029" plane="0 0 -1 -0.25" album="TGEDemo" material="asfalt_add_001" texgens="-1 0 0 960 0 -1 0 -960 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 4 1 0 7" />
                        </Face>
                        <Face id="1030" plane="-0 -1 -0 20" album="TGEDemo" material="asfalt_add_001" texgens="1 0 0 960 0 0 1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 6 7 0" />
                        </Face>
                        <Face id="1031" plane="1 -0 0 -12" album="TGEDemo" material="asfalt_add_001" texgens="0 -1 0 320 0 0 1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="107" owner="0" type="0" pos="-30 30 0.25" rot="1 0 0 0" scale="" transform="1 0 0 -30 0 1 0 30 0 0 1 0.25 0 0 0 1" group="-1" locked="0" nextFaceID="1033" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="30 20 0.25" />
                            <Vertex pos="30 30 0.25" />
                            <Vertex pos="30 30 -0.25" />
                            <Vertex pos="30 20 -0.25" />
                            <Vertex pos="12 30 -0.25" />
                            <Vertex pos="12 30 0.25" />
                            <Vertex pos="12 20 0.25" />
                            <Vertex pos="12 20 -0.25" />
                        </Vertices>
                        <Face id="1026" plane="1 0 0 -30" album="TGEDemo" material="asfalt_001" texgens="0 1 0 960 0 0 -1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="1027" plane="0 1 -0 -30" album="TGEDemo" material="asfalt_001" texgens="1 0 0 320 0 0 -1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 4 2 1 5" />
                        </Face>
                        <Face id="1028" plane="0 -0 1 -0.25" album="TGEDemo" material="asfalt_001" texgens="1 0 0 1264 0 -1 0 2704 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 1 0 6 5" />
                        </Face>
                        <Face id="1029" plane="-0 -0 -1 -0.25" album="TGEDemo" material="asfalt_001" texgens="-1 0 0 960 0 -1 0 -960 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 2 4 7" />
                        </Face>
                        <Face id="1030" plane="-0 -1 -0 20" album="TGEDemo" material="asfalt_001" texgens="1 0 0 960 0 0 1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 0 3 7" />
                        </Face>
                        <Face id="1031" plane="-1 0 0 12" album="TGEDemo" material="asfalt_001" texgens="0 -1 0 320 0 0 1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="121" owner="0" type="0" pos="-20 35 10.7" rot="1 0 0 0" scale="" transform="2 0 0 -20 0 1 0 35 0 0 2.66667 10.7 0 0 0 1" group="-1" locked="0" nextFaceID="4339" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-10.5 -35.5 -0.3" />
                            <Vertex pos="-10.5 35.5 -0.3" />
                            <Vertex pos="-10.5 35.5 0.3" />
                            <Vertex pos="-10.5 -35.5 0.3" />
                            <Vertex pos="-9.5 35.5 -0.3" />
                            <Vertex pos="-9.5 35.5 0.3" />
                            <Vertex pos="-9.5 -35.5 0.3" />
                            <Vertex pos="-9.5 -35.5 -0.3" />
                        </Vertices>
                        <Face id="4332" plane="-1 0 0 -10.5" album="Starter" material="cement" texgens="0 1 0 256 0 0 1 256 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="4333" plane="0 1 -0 -35.5" album="Starter" material="cement" texgens="-1 0 0 976 0 0 -1 -9.6 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="4334" plane="-0 -1 -0 -35.5" album="Starter" material="cement" texgens="1 0 0 976 0 0 -1 -9.6 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 3 6 7 0" />
                        </Face>
                        <Face id="4335" plane="0 0 1 -0.3" album="Starter" material="cement" texgens="1 0 0 976 0 -1 0 -1136 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 2 5 6 3" />
                        </Face>
                        <Face id="4336" plane="0 0 -1 -0.3" album="Starter" material="cement" texgens="-1 0 0 -64 0 -1 0 256 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="4337" plane="1 -0 0 9.5" album="Starter" material="cement" texgens="0 1 0 256 0 0 1 256 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="139" owner="0" type="0" pos="-30 35 11.2" rot="1 0 0 0" scale="" transform="1 0 0 -30 0 1 0 35 0 0 1 11.2 0 0 0 1" group="-1" locked="0" nextFaceID="4339" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="30.5 -35.5 -0.3" />
                            <Vertex pos="30.5 -35.5 0.3" />
                            <Vertex pos="30.5 35.5 0.3" />
                            <Vertex pos="30.5 35.5 -0.3" />
                            <Vertex pos="11 35.5 -0.3" />
                            <Vertex pos="11 35.5 0.3" />
                            <Vertex pos="11 -35.5 0.3" />
                            <Vertex pos="11 -35.5 -0.3" />
                        </Vertices>
                        <Face id="4332" plane="1 -0 0 -30.5" album="Starter" material="cement" texgens="0 1 0 1136 0 0 -1 -9.6 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="4333" plane="0 1 -0 -35.5" album="Starter" material="cement" texgens="-1 0 0 976 0 0 -1 -9.6 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 4 3 2 5" />
                        </Face>
                        <Face id="4334" plane="-0 -1 -0 -35.5" album="Starter" material="cement" texgens="1 0 0 976 0 0 -1 -9.6 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 6 1 0 7" />
                        </Face>
                        <Face id="4335" plane="0 0 1 -0.3" album="Starter" material="cement" texgens="1 0 0 976 0 -1 0 -1136 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 5 2 1 6" />
                        </Face>
                        <Face id="4336" plane="0 0 -1 -0.3" album="Starter" material="cement" texgens="-1 0 0 976 0 -1 0 -1136 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 7 0 3 4" />
                        </Face>
                        <Face id="4337" plane="-1 0 0 11" album="Starter" material="cement" texgens="0 1 0 256 0 0 0.375 262 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="144" owner="0" type="0" pos="-30 35 11.2" rot="1 0 0 0" scale="" transform="1 0 0 -30 0 1 0 35 0 0 1 11.2 0 0 0 1" group="-1" locked="0" nextFaceID="4339" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-30.5 -35.5 -0.3" />
                            <Vertex pos="-30.5 35.5 -0.3" />
                            <Vertex pos="-30.5 35.5 0.3" />
                            <Vertex pos="-30.5 -35.5 0.3" />
                            <Vertex pos="-11 35.5 -0.3" />
                            <Vertex pos="-11 35.5 0.3" />
                            <Vertex pos="-11 -35.5 0.3" />
                            <Vertex pos="-11 -35.5 -0.3" />
                        </Vertices>
                        <Face id="4332" plane="-1 0 0 -30.5" album="Starter" material="cement" texgens="0 -1 0 1136 0 0 -1 -9.6 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="4333" plane="0 1 -0 -35.5" album="Starter" material="cement" texgens="-1 0 0 976 0 0 -1 -9.6 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="4334" plane="0 -1 0 -35.5" album="Starter" material="cement" texgens="1 0 0 976 0 0 -1 -9.6 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 0 3 6 7" />
                        </Face>
                        <Face id="4335" plane="-0 0 1 -0.3" album="Starter" material="cement" texgens="1 0 0 976 0 -1 0 -1136 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 3 2 5 6" />
                        </Face>
                        <Face id="4336" plane="0 0 -1 -0.3" album="Starter" material="cement" texgens="-1 0 0 976 0 -1 0 -1136 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="4337" plane="1 -0 0 11" album="Starter" material="cement" texgens="0 1 0 256 0 0 0.375 262 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="147" owner="0" type="0" pos="-30 35 11.2" rot="1 0 0 0" scale="" transform="1 0 0 -30 0 1 0 35 0 0 1 11.2 0 0 0 1" group="-1" locked="0" nextFaceID="4351" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="9 -35.5 -0.3" />
                            <Vertex pos="9 -35.5 0.3" />
                            <Vertex pos="9 35.5 0.3" />
                            <Vertex pos="9 35.5 -0.3" />
                            <Vertex pos="-9 35.5 -0.3" />
                            <Vertex pos="-9 35.5 0.3" />
                            <Vertex pos="-9 -35.5 0.3" />
                            <Vertex pos="-9 -35.5 -0.3" />
                        </Vertices>
                        <Face id="4344" plane="1 -0 0 -9" album="Starter" material="cement" texgens="0 1 0 256 0 0 0.375 262 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="4345" plane="0 1 -0 -35.5" album="Starter" material="cement" texgens="-1 0 0 976 0 0 -1 -9.6 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 4 3 2 5" />
                        </Face>
                        <Face id="4346" plane="-0 -1 -0 -35.5" album="Starter" material="cement" texgens="1 0 0 976 0 0 -1 -9.6 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 6 1 0 7" />
                        </Face>
                        <Face id="4347" plane="0 0 1 -0.3" album="Starter" material="cement" texgens="1 0 0 976 0 -1 0 -1136 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 5 2 1 6" />
                        </Face>
                        <Face id="4348" plane="0 0 -1 -0.3" album="Starter" material="cement" texgens="-1 0 0 976 0 -1 0 -1136 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 7 0 3 4" />
                        </Face>
                        <Face id="4349" plane="-1 0 0 -9" album="Starter" material="cement" texgens="0 1 0 256 0 0 0.375 262 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="156" owner="0" type="0" pos="-40 30 7.5" rot="1 0 0 0" scale="" transform="1 0 0 -40 0 1 0 30 0 0 1.25 7.5 0 0 0 1" group="-1" locked="0" nextFaceID="1130" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.5 -0.5 -4" />
                            <Vertex pos="-0.5 0.5 -4" />
                            <Vertex pos="-0.5 0.5 -0.511995" />
                            <Vertex pos="-0.5 -0.5 -0.511995" />
                            <Vertex pos="0 -0.5 -4" />
                            <Vertex pos="0 0.5 -4" />
                            <Vertex pos="0 0.5 -0.32" />
                            <Vertex pos="0 -0.5 -0.32" />
                        </Vertices>
                        <Face id="1116" plane="-1 0 0 -0.5" album="Starter" material="cement" texgens="0 -1 0 16 0 0 -1 -128 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="1117" plane="0 0 -1 -4" album="Starter" material="cement" texgens="-1 0 0 16 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 0 4 5 1" />
                        </Face>
                        <Face id="1118" plane="0 1 -0 -0.5" album="Starter" material="cement" texgens="-1 0 0 16 0 0 -1 -128 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 1 5 6 2" />
                        </Face>
                        <Face id="1119" plane="0 -1 0 -0.5" album="Starter" material="cement" texgens="1 0 0 16 0 0 -1 -128 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 0 3 7 4" />
                        </Face>
                        <Face id="1121" plane="1 0 0 -0" album="Starter" material="cement" texgens="0 -1 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                        <Face id="1128" plane="-0.35847 0 0.933541 0.298733" album="Starter" material="cement9" texgens="0 -0.0638694 0 2632.44 -0.063739 0 0.0040793 1.37793 0 -0.0375 0.0304198" texRot="0" texScale="-0.0375 0.0304198" texDiv="512 512">
                            <Indices indices=" 3 2 6 7" />
                        </Face>
                    </Brush>
                    <Brush id="157" owner="0" type="0" pos="-40 30 7.5" rot="1 0 0 0" scale="" transform="1 0 0 -40 0 1 0 30 0 0 1.25 7.5 0 0 0 1" group="-1" locked="0" nextFaceID="1130" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 -0.5 -4" />
                            <Vertex pos="0.5 -0.5 -0.32" />
                            <Vertex pos="0.5 0.5 -0.32" />
                            <Vertex pos="0.5 0.5 -4" />
                            <Vertex pos="0 -0.5 -4" />
                            <Vertex pos="0 0.5 -4" />
                            <Vertex pos="0 0.5 -0.32" />
                            <Vertex pos="0 -0.5 -0.32" />
                        </Vertices>
                        <Face id="1116" plane="1 -0 0 -0.5" album="Starter" material="cement" texgens="0 1 0 16 0 0 -1 -128 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="1117" plane="0 0 -1 -4" album="Starter" material="cement" texgens="-1 0 0 16 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 4 0 3 5" />
                        </Face>
                        <Face id="1118" plane="0 1 -0 -0.5" album="Starter" material="cement" texgens="-1 0 0 16 0 0 -1 -128 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 5 3 2 6" />
                        </Face>
                        <Face id="1119" plane="-0 -1 -0 -0.5" album="Starter" material="cement" texgens="1 0 0 16 0 0 -1 -128 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 7 1 0 4" />
                        </Face>
                        <Face id="1121" plane="-1 0 0 0" album="Starter" material="cement" texgens="0 -1 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                        <Face id="1128" plane="0 0 1 0.32" album="Starter" material="cement9" texgens="0 -0.0638694 0 16.3506 -0.063739 0 0.0040793 34.0405 0 0.0625001 0.0311864" texRot="0" texScale="0.0625001 0.0311864" texDiv="512 512">
                            <Indices indices=" 6 2 1 7" />
                        </Face>
                    </Brush>
                    <Brush id="162" owner="0" type="0" pos="-40 30 7.5" rot="1 0 0 0" scale="" transform="1 0 0 -40 0 1 0 30 0 0 1.25 7.5 0 0 0 1" group="-1" locked="0" nextFaceID="1123" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0 -0.5 0.4" />
                            <Vertex pos="0.5 -0.5 0.4" />
                            <Vertex pos="0.5 0.5 0.4" />
                            <Vertex pos="0 0.5 0.4" />
                            <Vertex pos="0.5 -0.5 1.00469" />
                            <Vertex pos="0.5 0.5 1.00489" />
                            <Vertex pos="0 0.5 1.11987" />
                            <Vertex pos="0 -0.5 1.11967" />
                        </Vertices>
                        <Face id="1116" plane="0 0 -1 0.4" album="Starter" material="cement9" texgens="0 1 0 16 1 0 0 -128 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="1117" plane="1 -0 0 -0.5" album="Starter" material="cement" texgens="0 1 0 16 0 0 -1 -128 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="1118" plane="0 1 0 -0.5" album="Starter" material="cement" texgens="-1 0 0 16 0 0 -1 -128 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 2 5 6 3" />
                        </Face>
                        <Face id="1119" plane="0 -1 0 -0.5" album="Starter" material="cement" texgens="1 0 0 16 0 0 -1 -128 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 4 1 0 7" />
                        </Face>
                        <Face id="1120" plane="-1 0 0 -0" album="Starter" material="cement9" texgens="0 -1 0 1296 0 0 1 -976 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 0 3 6 7" />
                        </Face>
                        <Face id="1121" plane="0.224111 -0.000194829 0.974564 -1.09129" album="Starter" material="cement" texgens="-0.000190344 -0.224113 0 16 -0.218412 0.000185503 0.0502266 -128 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="165" owner="0" type="0" pos="-39.75 30.25 7.45" rot="1 0 0 0" scale="" transform="1 0 0 -39.75 0 1 0 30.25 0 0 1 7.45 0 0 0 1" group="-1" locked="0" nextFaceID="451" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.0499954 0.0499954 0.95" />
                            <Vertex pos="0.0499954 0.0499954 -0.95" />
                            <Vertex pos="0.0499954 -0.0499954 0.95" />
                            <Vertex pos="0.0499954 -0.0499954 -0.95" />
                            <Vertex pos="-0.0499954 0.0499954 0.95" />
                            <Vertex pos="-0.0499954 0.0499954 -0.95" />
                            <Vertex pos="-0.0499954 -0.0499954 0.95" />
                            <Vertex pos="-0.0499954 -0.0499954 -0.95" />
                        </Vertices>
                        <Face id="444" plane="1 -0 0 -0.0499954" album="Starter" material="wall6" texgens="0 1 0 3268.51 0 0 -1 -984 0 0.2 0.2" texRot="0" texScale="0.2 0.2" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="445" plane="-1 0 0 -0.0499954" album="Starter" material="wall6" texgens="0 -1 0 7.99926 0 0 -1 -984 0 0.2 0.2" texRot="0" texScale="0.2 0.2" texDiv="512 512">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="446" plane="0 1 -0 -0.0499954" album="Starter" material="wall6" texgens="-1 0 0 9582.4 0 0 -1 -984 0 0.2 0.2" texRot="0" texScale="0.2 0.2" texDiv="512 512">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="447" plane="0 -1 0 -0.0499954" album="Starter" material="wall6" texgens="1 0 0 2.44235e+006 0 0 -1 -984 0 0.2 0.2" texRot="0" texScale="0.2 0.2" texDiv="512 512">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="448" plane="-0 0 1 -0.95" album="Starter" material="wall6" texgens="1 0 0 1.59985 0 -1 0 -1.59985 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="449" plane="0 0 -1 -0.95" album="Starter" material="wall6" texgens="-1 0 0 1.59985 0 -1 0 -1.59985 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="167" owner="0" type="0" pos="-39.75 29.65 7.45" rot="1 0 0 0" scale="" transform="1 0 0 -39.75 0 1 0 29.65 0 0 1 7.45 0 0 0 1" group="-1" locked="0" nextFaceID="457" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.0499954 -0.0499954 0.95" />
                            <Vertex pos="-0.0499954 0.0499954 0.95" />
                            <Vertex pos="0.0499954 0.0499954 0.95" />
                            <Vertex pos="0.0499954 -0.0499954 0.95" />
                            <Vertex pos="0.0499954 -0.0499954 0.122879" />
                            <Vertex pos="0.0499954 0.0499954 0.122879" />
                            <Vertex pos="-0.0499954 0.0499954 0.165229" />
                            <Vertex pos="-0.0499954 -0.0499954 0.165229" />
                        </Vertices>
                        <Face id="450" plane="-0 0 1 -0.95" album="Starter" material="wall6" texgens="1 0 0 1.59985 0 -1 0 -1.59985 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="451" plane="1 -0 0 -0.0499954" album="Starter" material="wall6" texgens="0 1 0 3268.51 0 0 -1 -984 0 0.2 0.2" texRot="0" texScale="0.2 0.2" texDiv="512 512">
                            <Indices indices=" 4 3 2 5" />
                        </Face>
                        <Face id="452" plane="-1 -0 -0 -0.0499954" album="Starter" material="wall6" texgens="0 -1 0 7.99926 0 0 -1 -984 0 0.2 0.2" texRot="0" texScale="0.2 0.2" texDiv="512 512">
                            <Indices indices=" 6 1 0 7" />
                        </Face>
                        <Face id="453" plane="0 1 0 -0.0499954" album="Starter" material="wall6" texgens="-1 0 0 9582.4 0 0 -1 -984 0 0.2 0.2" texRot="0" texScale="0.2 0.2" texDiv="512 512">
                            <Indices indices=" 5 2 1 6" />
                        </Face>
                        <Face id="454" plane="0 -1 0 -0.0499954" album="Starter" material="wall6" texgens="1 0 0 2.44235e+006 0 0 -1 -984 0 0.2 0.2" texRot="0" texScale="0.2 0.2" texDiv="512 512">
                            <Indices indices=" 7 0 3 4" />
                        </Face>
                        <Face id="455" plane="-0.390001 0 -0.920815 0.132647" album="Starter" material="cement9" texgens="0 -0.389998 0 99.8405 -0.359116 0 0.152098 -3.46806 0 0.00624936 0.00678685" texRot="0" texScale="0.00624936 0.00678685" texDiv="512 512">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="168" owner="0" type="0" pos="-39.75 29.65 7.45" rot="1 0 0 0" scale="" transform="1 0 0 -39.75 0 1 0 29.65 0 0 1 7.45 0 0 0 1" group="-1" locked="0" nextFaceID="463" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.0499954 -0.0499954 -0.95" />
                            <Vertex pos="0.0499954 -0.0499954 -0.95" />
                            <Vertex pos="0.0499954 0.0499954 -0.95" />
                            <Vertex pos="-0.0499954 0.0499954 -0.95" />
                            <Vertex pos="0.0499954 -0.0499954 -0.129534" />
                            <Vertex pos="0.0499954 0.0499954 -0.129534" />
                            <Vertex pos="-0.0499954 0.0499954 -0.136356" />
                            <Vertex pos="-0.0499954 -0.0499954 -0.136356" />
                        </Vertices>
                        <Face id="456" plane="0 0 -1 -0.95" album="Starter" material="wall6" texgens="-1 0 0 1.59985 0 -1 0 -1.59985 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="457" plane="1 -0 0 -0.0499954" album="Starter" material="wall6" texgens="0 1 0 3268.51 0 0 -1 -984 0 0.2 0.2" texRot="0" texScale="0.2 0.2" texDiv="512 512">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="458" plane="-1 0 0 -0.0499954" album="Starter" material="wall6" texgens="0 -1 0 7.99926 0 0 -1 -984 0 0.2 0.2" texRot="0" texScale="0.2 0.2" texDiv="512 512">
                            <Indices indices=" 0 3 6 7" />
                        </Face>
                        <Face id="459" plane="0 1 -0 -0.0499954" album="Starter" material="wall6" texgens="-1 0 0 9582.4 0 0 -1 -984 0 0.2 0.2" texRot="0" texScale="0.2 0.2" texDiv="512 512">
                            <Indices indices=" 3 2 5 6" />
                        </Face>
                        <Face id="460" plane="0 -1 0 -0.0499954" album="Starter" material="wall6" texgens="1 0 0 2.44235e+006 0 0 -1 -984 0 0.2 0.2" texRot="0" texScale="0.2 0.2" texDiv="512 512">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="461" plane="-0.0680679 0 0.997681 0.132637" album="Starter" material="wall6" texgens="0 0.0680676 0 3268.51 0.0679097 0 0.00463319 -984 0 0.2 0.2" texRot="0" texScale="0.2 0.2" texDiv="512 512">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="215" owner="0" type="0" pos="-40 50 7.5" rot="1 0 0 0" scale="" transform="1 0 0 -40 0 1 0 50 0 0 1.25 7.5 0 0 0 1" group="2" locked="0" nextFaceID="1129" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0 -4" />
                            <Vertex pos="0.5 0.5 -4" />
                            <Vertex pos="0 0.5 -4" />
                            <Vertex pos="0 0 -4" />
                            <Vertex pos="0.5 0.5 -2.50909" />
                            <Vertex pos="0 0.5 -2.32727" />
                            <Vertex pos="0.5 0 -2.50909" />
                            <Vertex pos="0 0 -2.32727" />
                        </Vertices>
                        <Face id="1122" plane="-0 -0 -1 -4" album="Starter" material="cement" texgens="-1 0 0 16 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="1123" plane="0 1 -0 -0.5" album="Starter" material="cement" texgens="-1 0 0 16 0 0 -1 -128 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 2 1 4 5" />
                        </Face>
                        <Face id="1124" plane="1 0 -0 -0.5" album="Starter" material="cement" texgens="0 1 0 16 0 0 -1 -128 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 4 1 0 6" />
                        </Face>
                        <Face id="1125" plane="-1 0 0 -0" album="Starter" material="cement9" texgens="0 -1 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 3 2 5 7" />
                        </Face>
                        <Face id="1126" plane="0 -1 0 -0" album="Starter" material="cement9" texgens="-1 0 0 16 0 0 1 -128 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 6 0 3 7" />
                        </Face>
                        <Face id="1127" plane="0.341746 0 0.939792 2.18715" album="Starter" material="cement" texgens="0 -0.341743 0 16 -0.321168 0 0.116789 -128 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="216" owner="0" type="0" pos="-40 50 7.5" rot="1 0 0 0" scale="" transform="1 0 0 -40 0 1 0 50 0 0 1.25 7.5 0 0 0 1" group="2" locked="0" nextFaceID="1129" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0 0 0.4" />
                            <Vertex pos="0 0.5 0.4" />
                            <Vertex pos="0.5 0.5 0.4" />
                            <Vertex pos="0.5 0 0.4" />
                            <Vertex pos="0.5 0.5 -2.50909" />
                            <Vertex pos="0 0.5 -2.32727" />
                            <Vertex pos="0.5 0 -2.50909" />
                            <Vertex pos="0 0 -2.32727" />
                        </Vertices>
                        <Face id="1122" plane="-0 0 1 -0.4" album="Starter" material="cement9" texgens="0 1 0 16 1 0 0 -128 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="1123" plane="0 1 0 -0.5" album="Starter" material="cement" texgens="-1 0 0 16 0 0 -1 -128 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 4 2 1 5" />
                        </Face>
                        <Face id="1124" plane="1 0 -0 -0.5" album="Starter" material="cement" texgens="0 1 0 16 0 0 -1 -128 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 2 4 6 3" />
                        </Face>
                        <Face id="1125" plane="-1 -0 -0 0" album="Starter" material="cement9" texgens="0 -1 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 5 1 0 7" />
                        </Face>
                        <Face id="1126" plane="0 -1 0 -0" album="Starter" material="cement9" texgens="-1 0 0 16 0 0 1 -128 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 3 6 7 0" />
                        </Face>
                        <Face id="1127" plane="-0.341746 0 -0.939792 -2.18715" album="Starter" material="cement" texgens="0 -0.341743 0 16 -0.321168 0 0.116789 -128 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="217" owner="0" type="0" pos="-40 50 7.5" rot="1 0 0 0" scale="" transform="1 0 0 -40 0 1 0 50 0 0 1.25 7.5 0 0 0 1" group="2" locked="0" nextFaceID="1129" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0 -0.5 -4" />
                            <Vertex pos="0.5 -0.5 -4" />
                            <Vertex pos="0.5 0 -4" />
                            <Vertex pos="0 0 -4" />
                            <Vertex pos="0.5 -0.5 -2.50909" />
                            <Vertex pos="0 -0.5 -2.32727" />
                            <Vertex pos="0.5 0 -2.50909" />
                            <Vertex pos="0 0 -2.32727" />
                        </Vertices>
                        <Face id="1122" plane="0 0 -1 -4" album="Starter" material="cement" texgens="-1 0 0 16 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="1123" plane="0 -1 0 -0.5" album="Starter" material="cement" texgens="1 0 0 16 0 0 -1 -128 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 4 1 0 5" />
                        </Face>
                        <Face id="1124" plane="1 -0 0 -0.5" album="Starter" material="cement" texgens="0 1 0 16 0 0 -1 -128 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 1 4 6 2" />
                        </Face>
                        <Face id="1125" plane="-1 0 0 0" album="Starter" material="cement9" texgens="0 -1 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 5 0 3 7" />
                        </Face>
                        <Face id="1126" plane="0 1 0 -0" album="Starter" material="cement9" texgens="-1 0 0 16 0 0 1 -128 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="1127" plane="0.341746 0 0.939792 2.18715" album="Starter" material="cement9" texgens="0 -0.341743 0 16 -0.321168 0 0.116789 -128 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="222" owner="0" type="0" pos="-20 50 7.5" rot="1 0 0 0" scale="" transform="1 0 0 -20 0 1 0 50 0 0 1.25 7.5 0 0 0 1" group="-1" locked="0" nextFaceID="811" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.5 -0.5 -4" />
                            <Vertex pos="0.5 -0.5 -4" />
                            <Vertex pos="0.5 0.5 -4" />
                            <Vertex pos="-0.5 0.5 -4" />
                            <Vertex pos="0.5 -0.5 -2.87067" />
                            <Vertex pos="0.5 0.5 -2.87077" />
                            <Vertex pos="-0.499996 0.5 -3.04" />
                            <Vertex pos="-0.499996 -0.5 -3.04" />
                        </Vertices>
                        <Face id="804" plane="0 0 -1 -4" album="Starter" material="cement" texgens="-1 0 0 16 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="805" plane="1 0 0 -0.5" album="Starter" material="cement" texgens="0 1 0 16 0 0 -1 -128 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="806" plane="-1 0 4.15991e-006 -0.499983" album="Starter" material="cement" texgens="0 -1 0 16 0 0 -1 -128 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 0 3 6 7" />
                        </Face>
                        <Face id="807" plane="0 1 -0 -0.5" album="Starter" material="cement" texgens="-1 0 0 16 0 0 -1 -128 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 3 2 5 6" />
                        </Face>
                        <Face id="808" plane="0 -1 -0 -0.5" album="Starter" material="cement" texgens="1 0 0 16 0 0 -1 -128 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="809" plane="-0.166858 0 0.985981 2.91395" album="Starter" material="cement9" texgens="0 0.488143 0 16 -0.426034 0 0.238284 -128 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="223" owner="0" type="0" pos="-22.1909 47.8473 1.09875" rot="0.811312 0.413384 -0.413384 1.77839" scale="" transform="0.587785 6.7811e-008 -1.01127 -22.1909 0.809017 -4.92676e-008 0.734732 47.8473 0 -1 -9.87202e-008 1.09875 0 0 0 1" group="3" locked="0" nextFaceID="824" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 -0.5 -2.87067" />
                            <Vertex pos="0.5 -0.5 0.64" />
                            <Vertex pos="0.5 0.5 0.64" />
                            <Vertex pos="0.5 0.5 -2.87077" />
                            <Vertex pos="0 0.5 0.978127" />
                            <Vertex pos="0 -0.5 0.978112" />
                            <Vertex pos="0 0.5 -2.59111" />
                            <Vertex pos="0 -0.5 -2.59102" />
                        </Vertices>
                        <Face id="810" plane="1 -0 0 -0.5" album="Starter" material="cement" texgens="0 1 0 16 0 0 -1 -128 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="812" plane="0 1 0 -0.5" album="Starter" material="cement" texgens="-1 0 0 16 0 0 -1 -128 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 3 2 4 6" />
                        </Face>
                        <Face id="813" plane="-0 -1 -0 -0.5" album="Starter" material="cement" texgens="1 0 0 16 0 0 -1 -128 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 5 1 0 7" />
                        </Face>
                        <Face id="814" plane="-0.488138 -8.71871e-005 -0.872766 -2.2614" album="Starter" material="cement9" texgens="0 0.488143 0 16 -0.426034 0 0.238284 -128 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 7 0 3 6" />
                        </Face>
                        <Face id="815" plane="-1 0 0 -0" album="Starter" material="cement" texgens="0 1 0 16 0 0 1 -128 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                        <Face id="822" plane="0.560186 0 0.828367 -0.810248" album="Starter" material="cement9" texgens="0 0.239365 0 16 -0.232407 0 0.0572956 -128 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 4 2 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="224" owner="0" type="0" pos="-22.1909 47.8473 1.09875" rot="0.811312 0.413384 -0.413384 1.77839" scale="" transform="0.587785 6.7811e-008 -1.01127 -22.1909 0.809017 -4.92676e-008 0.734732 47.8473 0 -1 -9.87202e-008 1.09875 0 0 0 1" group="3" locked="0" nextFaceID="817" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.5 0.5 -2.31146" />
                            <Vertex pos="-0.5 0.5 0.720001" />
                            <Vertex pos="-0.5 -0.5 0.720001" />
                            <Vertex pos="-0.5 -0.5 -2.31136" />
                            <Vertex pos="0 0.5 0.978127" />
                            <Vertex pos="0 -0.5 0.978112" />
                            <Vertex pos="0 0.5 -2.59111" />
                            <Vertex pos="0 -0.5 -2.59102" />
                        </Vertices>
                        <Face id="810" plane="-1 -0 -0 -0.5" album="Starter" material="cement" texgens="0 -1 0 16 0 0 -1 -128 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="811" plane="-0.458729 0 0.888576 -0.86914" album="Starter" material="cement9" texgens="0 0.239365 0 16 -0.232407 0 0.0572956 -128 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 2 1 4 5" />
                        </Face>
                        <Face id="812" plane="-0 1 0 -0.5" album="Starter" material="cement" texgens="-1 0 0 16 0 0 -1 -128 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 4 1 0 6" />
                        </Face>
                        <Face id="813" plane="0 -1 0 -0.5" album="Starter" material="cement" texgens="1 0 0 16 0 0 -1 -128 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 3 2 5 7" />
                        </Face>
                        <Face id="814" plane="-0.488152 -7.84469e-005 -0.872759 -2.26137" album="Starter" material="cement9" texgens="0 0.488143 0 16 -0.426034 0 0.238284 -128 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 3 7 6 0" />
                        </Face>
                        <Face id="815" plane="1 -0 0 -0" album="Starter" material="cement" texgens="0 1 0 16 0 0 1 -128 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="225" owner="0" type="0" pos="-19.95 49.619 4.53392" rot="-1 0 -0 0.244336" scale="" transform="1 0 0 -19.95 0 0.970296 -0.241922 49.619 0 0.241922 0.970296 4.53392 0 0 0 1" group="-1" locked="0" nextFaceID="463" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.0499954 -0.0499954 -0.95" />
                            <Vertex pos="0.0499954 -0.0499954 -0.95" />
                            <Vertex pos="0.0499954 0.0499954 -0.95" />
                            <Vertex pos="-0.0499954 0.0499954 -0.95" />
                            <Vertex pos="0.0499954 -0.0499954 -0.129534" />
                            <Vertex pos="0.0499954 0.0499954 -0.129534" />
                            <Vertex pos="-0.0499954 0.0499954 -0.136356" />
                            <Vertex pos="-0.0499954 -0.0499954 -0.136356" />
                        </Vertices>
                        <Face id="456" plane="0 0 -1 -0.95" album="Starter" material="wall6" texgens="-1 0 0 1.59985 0 -1 0 -1.59985 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="457" plane="1 -0 0 -0.0499954" album="Starter" material="wall6" texgens="0 1 0 3268.51 0 0 -1 -984 0 0.2 0.2" texRot="0" texScale="0.2 0.2" texDiv="512 512">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="458" plane="-1 0 0 -0.0499954" album="Starter" material="wall6" texgens="0 -1 0 7.99926 0 0 -1 -984 0 0.2 0.2" texRot="0" texScale="0.2 0.2" texDiv="512 512">
                            <Indices indices=" 0 3 6 7" />
                        </Face>
                        <Face id="459" plane="0 1 -0 -0.0499954" album="Starter" material="wall6" texgens="-1 0 0 9582.4 0 0 -1 -984 0 0.2 0.2" texRot="0" texScale="0.2 0.2" texDiv="512 512">
                            <Indices indices=" 3 2 5 6" />
                        </Face>
                        <Face id="460" plane="0 -1 0 -0.0499954" album="Starter" material="wall6" texgens="1 0 0 2.44235e+006 0 0 -1 -984 0 0.2 0.2" texRot="0" texScale="0.2 0.2" texDiv="512 512">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="461" plane="-0.0680679 0 0.997681 0.132637" album="Starter" material="wall6" texgens="0 0.0680676 0 3268.51 0.0679097 0 0.00463319 -984 0 0.2 0.2" texRot="0" texScale="0.2 0.2" texDiv="512 512">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="226" owner="0" type="0" pos="-20.15 50.2689 4.24967" rot="1.00024 0 0 0.034898" scale="" transform="1 0 0 -20.15 0 0.999391 0.0348995 50.2689 0 -0.0348995 0.999391 4.24967 0 0 0 1" group="-1" locked="0" nextFaceID="463" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.0499954 -0.0499954 -0.95" />
                            <Vertex pos="0.0499954 -0.0499954 -0.95" />
                            <Vertex pos="0.0499954 0.0499954 -0.95" />
                            <Vertex pos="-0.0499954 0.0499954 -0.95" />
                            <Vertex pos="0.0499954 -0.0499954 -0.129534" />
                            <Vertex pos="0.0499954 0.0499954 -0.129534" />
                            <Vertex pos="-0.0499954 0.0499954 -0.136356" />
                            <Vertex pos="-0.0499954 -0.0499954 -0.136356" />
                        </Vertices>
                        <Face id="456" plane="0 0 -1 -0.95" album="Starter" material="wall6" texgens="-1 0 0 1.59985 0 -1 0 -1.59985 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="457" plane="1 -0 0 -0.0499954" album="Starter" material="wall6" texgens="0 1 0 3268.51 0 0 -1 -984 0 0.2 0.2" texRot="0" texScale="0.2 0.2" texDiv="512 512">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="458" plane="-1 0 0 -0.0499954" album="Starter" material="wall6" texgens="0 -1 0 7.99926 0 0 -1 -984 0 0.2 0.2" texRot="0" texScale="0.2 0.2" texDiv="512 512">
                            <Indices indices=" 0 3 6 7" />
                        </Face>
                        <Face id="459" plane="0 1 -0 -0.0499954" album="Starter" material="wall6" texgens="-1 0 0 9582.4 0 0 -1 -984 0 0.2 0.2" texRot="0" texScale="0.2 0.2" texDiv="512 512">
                            <Indices indices=" 3 2 5 6" />
                        </Face>
                        <Face id="460" plane="0 -1 0 -0.0499954" album="Starter" material="wall6" texgens="1 0 0 2.44235e+006 0 0 -1 -984 0 0.2 0.2" texRot="0" texScale="0.2 0.2" texDiv="512 512">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="461" plane="-0.0680679 0 0.997681 0.132637" album="Starter" material="wall6" texgens="0 0.0680676 0 3268.51 0.0679097 0 0.00463319 -984 0 0.2 0.2" texRot="0" texScale="0.2 0.2" texDiv="512 512">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="228" owner="0" type="0" pos="-23.2807 48.7171 1.10853" rot="-0.873594 -0.344118 -0.344118 1.70553" scale="" transform="0.731354 3.81096e-008 0.681998 -23.2807 0.681998 -4.08676e-008 -0.731354 48.7171 0 1 -5.58794e-008 1.10853 0 0 0 1" group="4" locked="0" nextFaceID="463" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.0499954 -0.0499954 -0.95" />
                            <Vertex pos="0.0499954 -0.0499954 -0.95" />
                            <Vertex pos="0.0499954 0.0499954 -0.95" />
                            <Vertex pos="-0.0499954 0.0499954 -0.95" />
                            <Vertex pos="0.0499954 -0.0499954 -0.129534" />
                            <Vertex pos="0.0499954 0.0499954 -0.129534" />
                            <Vertex pos="-0.0499954 0.0499954 -0.136356" />
                            <Vertex pos="-0.0499954 -0.0499954 -0.136356" />
                        </Vertices>
                        <Face id="456" plane="0 0 -1 -0.95" album="Starter" material="wall6" texgens="-1 0 0 1.59985 0 -1 0 -1.59985 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="457" plane="1 -0 0 -0.0499954" album="Starter" material="wall6" texgens="0 1 0 3268.51 0 0 -1 -984 0 0.2 0.2" texRot="0" texScale="0.2 0.2" texDiv="512 512">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="458" plane="-1 0 0 -0.0499954" album="Starter" material="wall6" texgens="0 -1 0 7.99926 0 0 -1 -984 0 0.2 0.2" texRot="0" texScale="0.2 0.2" texDiv="512 512">
                            <Indices indices=" 0 3 6 7" />
                        </Face>
                        <Face id="459" plane="0 1 -0 -0.0499954" album="Starter" material="wall6" texgens="-1 0 0 9582.4 0 0 -1 -984 0 0.2 0.2" texRot="0" texScale="0.2 0.2" texDiv="512 512">
                            <Indices indices=" 3 2 5 6" />
                        </Face>
                        <Face id="460" plane="0 -1 0 -0.0499954" album="Starter" material="wall6" texgens="1 0 0 2.44235e+006 0 0 -1 -984 0 0.2 0.2" texRot="0" texScale="0.2 0.2" texDiv="512 512">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="461" plane="-0.0680679 0 0.997681 0.132637" album="Starter" material="wall6" texgens="0 0.0680676 0 3268.51 0.0679097 0 0.00463319 -984 0 0.2 0.2" texRot="0" texScale="0.2 0.2" texDiv="512 512">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="229" owner="0" type="0" pos="-22.7176 48.3241 1.10853" rot="1 0 0 0" scale="" transform="0.601815 4.46272e-008 0.798635 -22.7176 0.798636 -3.3629e-008 -0.601815 48.3241 0 1 -5.58794e-008 1.10853 0 0 0 1" group="-1" locked="0" nextFaceID="469" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.0499954 -0.0499954 -0.136356" />
                            <Vertex pos="-0.0499954 0.0499954 -0.136356" />
                            <Vertex pos="0.0499954 0.0499954 -0.129534" />
                            <Vertex pos="0.0499954 -0.0499954 -0.129534" />
                            <Vertex pos="0.0499954 -0.0499954 -0.823955" />
                            <Vertex pos="0.0499954 0.0499954 -0.823955" />
                            <Vertex pos="-0.0499954 0.0499954 -0.256879" />
                            <Vertex pos="-0.0499954 -0.0499954 -0.256879" />
                        </Vertices>
                        <Face id="462" plane="-0.0680679 0 0.997681 0.132637" album="Starter" material="wall6" texgens="0 0.0680676 0 3268.51 0.0679097 0 0.00463319 -984 0 0.2 0.2" texRot="0" texScale="0.2 0.2" texDiv="512 512">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="463" plane="1 -0 0 -0.0499954" album="Starter" material="wall6" texgens="0 1 0 3268.51 0 0 -1 -984 0 0.2 0.2" texRot="0" texScale="0.2 0.2" texDiv="512 512">
                            <Indices indices=" 4 3 2 5" />
                        </Face>
                        <Face id="464" plane="-1 -0 -0 -0.0499954" album="Starter" material="wall6" texgens="0 -1 0 7.99926 0 0 -1 -984 0 0.2 0.2" texRot="0" texScale="0.2 0.2" texDiv="512 512">
                            <Indices indices=" 6 1 0 7" />
                        </Face>
                        <Face id="465" plane="0 1 0 -0.0499954" album="Starter" material="wall6" texgens="-1 0 0 9582.4 0 0 -1 -984 0 0.2 0.2" texRot="0" texScale="0.2 0.2" texDiv="512 512">
                            <Indices indices=" 5 2 1 6" />
                        </Face>
                        <Face id="466" plane="0 -1 0 -0.0499954" album="Starter" material="wall6" texgens="1 0 0 2.44235e+006 0 0 -1 -984 0 0.2 0.2" texRot="0" texScale="0.2 0.2" texDiv="512 512">
                            <Indices indices=" 7 0 3 4" />
                        </Face>
                        <Face id="467" plane="-0.984808 0 -0.173648 -0.0938424" album="Starter" material="wall6" texgens="0 1 0 3268.51 0.173648 0 -0.984808 -1091.44 0 0.2 0.2" texRot="0" texScale="0.2 0.2" texDiv="512 512">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="230" owner="0" type="0" pos="-22.7176 48.3241 1.10853" rot="1 0 0 0" scale="" transform="0.601815 4.46272e-008 0.798635 -22.7176 0.798636 -3.3629e-008 -0.601815 48.3241 0 1 -5.58794e-008 1.10853 0 0 0 1" group="-1" locked="0" nextFaceID="474" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-0.0499954 -0.0499954 -0.95" />
                            <Vertex pos="-0.0293114 -0.0499954 -0.95" />
                            <Vertex pos="-0.0293114 0.0499954 -0.95" />
                            <Vertex pos="-0.0499954 0.0499954 -0.95" />
                            <Vertex pos="-0.0499954 0.0499954 -0.832695" />
                            <Vertex pos="-0.0499954 -0.0499954 -0.832695" />
                        </Vertices>
                        <Face id="468" plane="0 0 -1 -0.95" album="Starter" material="wall6" texgens="-1 0 0 1.59985 0 -1 0 -1.59985 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="469" plane="-1 0 0 -0.0499954" album="Starter" material="wall6" texgens="0 -1 0 7.99926 0 0 -1 -984 0 0.2 0.2" texRot="0" texScale="0.2 0.2" texDiv="512 512">
                            <Indices indices=" 0 3 4 5" />
                        </Face>
                        <Face id="470" plane="0 1 0 -0.0499954" album="Starter" material="wall6" texgens="-1 0 0 9582.4 0 0 -1 -984 0 0.2 0.2" texRot="0" texScale="0.2 0.2" texDiv="512 512">
                            <Indices indices=" 3 2 4" />
                        </Face>
                        <Face id="471" plane="0 -1 0 -0.0499954" album="Starter" material="wall6" texgens="1 0 0 2.44235e+006 0 0 -1 -984 0 0.2 0.2" texRot="0" texScale="0.2 0.2" texDiv="512 512">
                            <Indices indices=" 0 5 1" />
                        </Face>
                        <Face id="472" plane="0.984808 0 0.173648 0.193832" album="Starter" material="wall6" texgens="0 -1 0 7.99925 0.173648 0 -0.984808 -1091.44 0 0.2 0.2" texRot="0" texScale="0.2 0.2" texDiv="512 512">
                            <Indices indices=" 5 4 2 1" />
                        </Face>
                    </Brush>
                    <Brush id="231" owner="0" type="0" pos="-22.7176 48.3241 1.10853" rot="1 0 0 0" scale="" transform="0.601815 4.46272e-008 0.798635 -22.7176 0.798636 -3.3629e-008 -0.601815 48.3241 0 1 -5.58794e-008 1.10853 0 0 0 1" group="4" locked="0" nextFaceID="481" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-0.0499954 -0.0499954 -0.256879" />
                            <Vertex pos="-0.0499954 0.0499954 -0.256879" />
                            <Vertex pos="0.0466799 0.0499954 -0.805152" />
                            <Vertex pos="0.0466799 -0.0499954 -0.805152" />
                            <Vertex pos="-0.0499954 0.0499954 -0.829082" />
                            <Vertex pos="-0.0499954 -0.0499954 -0.829082" />
                        </Vertices>
                        <Face id="475" plane="0.984808 0 0.173648 0.0938424" album="Starter" material="wall6" texgens="0 1 0 3268.51 0.173648 0 -0.984808 -1091.44 0 0.2 0.2" texRot="0" texScale="0.2 0.2" texDiv="512 512">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="476" plane="-1 -0 -0 -0.0499954" album="Starter" material="wall6" texgens="0 -1 0 7.99926 0 0 -1 -984 0 0.2 0.2" texRot="0" texScale="0.2 0.2" texDiv="512 512">
                            <Indices indices=" 4 1 0 5" />
                        </Face>
                        <Face id="477" plane="0 1 0 -0.0499954" album="Starter" material="wall6" texgens="-1 0 0 9582.4 0 0 -1 -984 0 0.2 0.2" texRot="0" texScale="0.2 0.2" texDiv="512 512">
                            <Indices indices=" 2 1 4" />
                        </Face>
                        <Face id="478" plane="0 -1 0 -0.0499954" album="Starter" material="wall6" texgens="1 0 0 2.44235e+006 0 0 -1 -984 0 0.2 0.2" texRot="0" texScale="0.2 0.2" texDiv="512 512">
                            <Indices indices=" 5 0 3" />
                        </Face>
                        <Face id="479" plane="0.240278 0 -0.970704 -0.792781" album="Starter" material="wall6" texgens="0 0.0680676 0 3268.51 0.0660735 0 0.0163552 -981.939 0 0.2 0.2" texRot="0" texScale="0.2 0.2" texDiv="512 512">
                            <Indices indices=" 5 3 2 4" />
                        </Face>
                    </Brush>
                    <Brush id="237" owner="0" type="0" pos="-30.25 70.25 5.25" rot="1 0 0 0" scale="" transform="1 0 0 -30.25 0 1 0 70.25 0 0 1 5.25 0 0 0 1" group="-1" locked="0" nextFaceID="4399" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-30.25 -0.25 -5.25" />
                            <Vertex pos="-9.75 -0.25 -5.25" />
                            <Vertex pos="-9.75 0.25 -5.25" />
                            <Vertex pos="-30.25 0.25 -5.25" />
                            <Vertex pos="-30.25 0.25 4.65" />
                            <Vertex pos="-30.25 -0.25 4.65" />
                            <Vertex pos="-9.75 0.25 4.65" />
                            <Vertex pos="-9.75 -0.25 4.65" />
                        </Vertices>
                        <Face id="4392" plane="0 0 -1 -5.25" album="Starter" material="cement" texgens="-1 0 0 968 0 -1 0 -8 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="4393" plane="-1 0 0 -30.25" album="Starter" material="cement" texgens="0 -1 0 8 0 0 -1 -168 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 0 3 4 5" />
                        </Face>
                        <Face id="4394" plane="0 1 -0 -0.25" album="Starter" material="cement" texgens="-1 0 0 968 0 0 -1 -168 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 3 2 6 4" />
                        </Face>
                        <Face id="4395" plane="0 -1 0 -0.25" album="Starter" material="cement" texgens="1 0 0 968 0 0 -1 -168 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 0 5 7 1" />
                        </Face>
                        <Face id="4396" plane="1 0 -0 9.75" album="Starter" material="cement" texgens="0 -1 0 8 0 0 -1 -168 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 6 2 1 7" />
                        </Face>
                        <Face id="4397" plane="0 0 1 -4.65" album="Starter" material="cement" texgens="-0.5 0 0 100 0 -1 0 -872 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="241" owner="0" type="0" pos="-30 70.25 5.2" rot="1 0 0 0" scale="" transform="1 0 0 -30 0 1 0 70.25 0 0 1.01961 5.2 0 0 0 1" group="-1" locked="0" nextFaceID="2005" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-7 -0.25 4.6096" />
                            <Vertex pos="-7 -0.25 5.1" />
                            <Vertex pos="-7 0.25 5.1" />
                            <Vertex pos="-7 0.25 4.6096" />
                            <Vertex pos="-9 0.25 5.1" />
                            <Vertex pos="-9 -0.25 5.1" />
                            <Vertex pos="-9 0.25 4.6096" />
                            <Vertex pos="-9 -0.25 4.6096" />
                        </Vertices>
                        <Face id="1998" plane="1 -0 0 7" album="TGEDemo" material="Mtl" texgens="0 -1 0 8 0 0 -1 -169.6 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="1999" plane="0 0 1 -5.1" album="Starter" material="cement10" texgens="1 0 0 320 0 -1 0 -8 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 4 2 1 5" />
                        </Face>
                        <Face id="2000" plane="0 1 0 -0.25" album="Starter" material="cement10" texgens="-1 0 0 320 0 0 -1 -163.2 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 3 2 4 6" />
                        </Face>
                        <Face id="2001" plane="-0 -1 -0 -0.25" album="Starter" material="cement10" texgens="1 0 0 320 0 0 -1 -163.2 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 5 1 0 7" />
                        </Face>
                        <Face id="2002" plane="-0 -0 -1 4.6096" album="Starter" material="cement" texgens="-0.5 0 0 96 0 -1 0 -872 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 0 3 6 7" />
                        </Face>
                        <Face id="2003" plane="-1 0 0 -9" album="Starter" material="cement" texgens="0 1 0 1384 0 0 0.382353 190 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="242" owner="0" type="0" pos="-40 10 7.5" rot="1 0 0 0" scale="" transform="1 0 0 -40 0 1 0 10 0 0 1.25 7.5 0 0 0 1" group="-1" locked="0" nextFaceID="3649" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.5 -0.5 -4" />
                            <Vertex pos="0.5 -0.5 -4" />
                            <Vertex pos="0.5 0.5 -4" />
                            <Vertex pos="-0.5 0.5 -4" />
                            <Vertex pos="0.5 -0.5 1.92" />
                            <Vertex pos="0.5 0.5 1.92" />
                            <Vertex pos="-0.5 0.5 1.92" />
                            <Vertex pos="-0.5 -0.5 1.92" />
                        </Vertices>
                        <Face id="3642" plane="0 0 -1 -4" album="Starter" material="cement" texgens="-1 0 0 16 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="3643" plane="1 -0 0 -0.5" album="Starter" material="cement" texgens="0 1 0 16 0 0 -1 -128 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="3644" plane="-1 0 0 -0.5" album="Starter" material="cement" texgens="0 -1 0 16 0 0 -1 -128 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 0 3 6 7" />
                        </Face>
                        <Face id="3645" plane="0 1 -0 -0.5" album="Starter" material="cement" texgens="-1 0 0 16 0 0 -1 -128 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 3 2 5 6" />
                        </Face>
                        <Face id="3646" plane="0 -1 0 -0.5" album="Starter" material="cement" texgens="1 0 0 16 0 0 -1 -128 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="3647" plane="-0 0 1 -1.92" album="Starter" material="cement" texgens="-0.5 0 0 256 0 -1 0 1056 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="243" owner="0" type="0" pos="-40 30 7.5" rot="1 0 0 0" scale="" transform="1 0 0 -40 0 1 0 30 0 0 1.25 7.5 0 0 0 1" group="-1" locked="0" nextFaceID="1129" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0 -0.5 1.11967" />
                            <Vertex pos="0 0.5 1.11987" />
                            <Vertex pos="-0.5 0.5 1.23485" />
                            <Vertex pos="-0.5 -0.5 1.23465" />
                            <Vertex pos="-0.5 0.5 1.92" />
                            <Vertex pos="-0.5 -0.5 1.92" />
                            <Vertex pos="0 0.5 1.92" />
                            <Vertex pos="0 -0.5 1.92" />
                        </Vertices>
                        <Face id="1122" plane="-0.224111 0.000194829 -0.974564 1.09129" album="Starter" material="cement9" texgens="-0.000190344 -0.224113 0 16 -0.218412 0.000185503 0.0502266 -128 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="1123" plane="-1 -0 -0 -0.5" album="Starter" material="cement" texgens="0 -1 0 16 0 0 -1 -128 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 2 4 5 3" />
                        </Face>
                        <Face id="1124" plane="-0 1 0 -0.5" album="Starter" material="cement" texgens="-1 0 0 16 0 0 -1 -128 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 4 2 1 6" />
                        </Face>
                        <Face id="1125" plane="0 -1 0 -0.5" album="Starter" material="cement" texgens="1 0 0 16 0 0 -1 -128 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 3 5 7 0" />
                        </Face>
                        <Face id="1126" plane="1 -0 0 -0" album="Starter" material="cement" texgens="0 -1 0 1296 0 0 1 -976 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 0 7 6 1" />
                        </Face>
                        <Face id="1127" plane="0 0 1 -1.92" album="Starter" material="cement" texgens="-0.5 0 0 256 0 -1 0 416 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="244" owner="0" type="0" pos="-40 30 7.5" rot="1 0 0 0" scale="" transform="1 0 0 -40 0 1 0 30 0 0 1.25 7.5 0 0 0 1" group="-1" locked="0" nextFaceID="1129" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0 -0.5 1.11967" />
                            <Vertex pos="0.5 -0.5 1.00469" />
                            <Vertex pos="0.5 0.5 1.00489" />
                            <Vertex pos="0 0.5 1.11987" />
                            <Vertex pos="0.5 -0.5 1.92" />
                            <Vertex pos="0.5 0.5 1.92" />
                            <Vertex pos="0 0.5 1.92" />
                            <Vertex pos="0 -0.5 1.92" />
                        </Vertices>
                        <Face id="1122" plane="-0.224111 0.000194829 -0.974564 1.09129" album="Starter" material="cement" texgens="-0.000190344 -0.224113 0 16 -0.218412 0.000185503 0.0502266 -128 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="1123" plane="1 -0 0 -0.5" album="Starter" material="cement" texgens="0 1 0 16 0 0 -1 -128 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="1124" plane="0 1 0 -0.5" album="Starter" material="cement" texgens="-1 0 0 16 0 0 -1 -128 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 2 5 6 3" />
                        </Face>
                        <Face id="1125" plane="0 -1 0 -0.5" album="Starter" material="cement" texgens="1 0 0 16 0 0 -1 -128 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 4 1 0 7" />
                        </Face>
                        <Face id="1126" plane="-1 -0 -0 0" album="Starter" material="cement" texgens="0 -1 0 1296 0 0 1 -976 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 3 6 7 0" />
                        </Face>
                        <Face id="1127" plane="-0 0 1 -1.92" album="Starter" material="cement" texgens="-0.5 0 0 256 0 -1 0 416 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="245" owner="0" type="0" pos="-40 50 7.5" rot="1 0 0 0" scale="" transform="1 0 0 -40 0 1 0 50 0 0 1.25 7.5 0 0 0 1" group="2" locked="0" nextFaceID="1117" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.5 -0.5 -4" />
                            <Vertex pos="0 -0.5 -4" />
                            <Vertex pos="0 0.5 -4" />
                            <Vertex pos="-0.5 0.5 -4" />
                            <Vertex pos="-0.5 0.5 1.92" />
                            <Vertex pos="-0.5 -0.5 1.92" />
                            <Vertex pos="0 0.5 1.92" />
                            <Vertex pos="0 -0.5 1.92" />
                        </Vertices>
                        <Face id="1110" plane="0 0 -1 -4" album="Starter" material="cement" texgens="-1 0 0 16 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="1111" plane="-1 0 0 -0.5" album="Starter" material="cement" texgens="0 -1 0 16 0 0 -1 -128 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 0 3 4 5" />
                        </Face>
                        <Face id="1112" plane="0 1 -0 -0.5" album="Starter" material="cement" texgens="-1 0 0 16 0 0 -1 -128 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 3 2 6 4" />
                        </Face>
                        <Face id="1113" plane="0 -1 0 -0.5" album="Starter" material="cement" texgens="1 0 0 16 0 0 -1 -128 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 0 5 7 1" />
                        </Face>
                        <Face id="1114" plane="1 0 -0 -0" album="Starter" material="cement9" texgens="0 -1 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 6 2 1 7" />
                        </Face>
                        <Face id="1115" plane="0 0 1 -1.92" album="Starter" material="cement" texgens="-0.5 0 0 256 0 -1 0 -224 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="246" owner="0" type="0" pos="-40 50 7.5" rot="1 0 0 0" scale="" transform="1 0 0 -40 0 1 0 50 0 0 1.25 7.5 0 0 0 1" group="2" locked="0" nextFaceID="1129" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0 0 0.4" />
                            <Vertex pos="0.5 0 0.4" />
                            <Vertex pos="0.5 0.5 0.4" />
                            <Vertex pos="0 0.5 0.4" />
                            <Vertex pos="0.5 0.5 1.92" />
                            <Vertex pos="0 0.5 1.92" />
                            <Vertex pos="0.5 0 1.92" />
                            <Vertex pos="0 0 1.92" />
                        </Vertices>
                        <Face id="1122" plane="0 0 -1 0.4" album="Starter" material="cement" texgens="0 1 0 16 1 0 0 -128 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="1123" plane="0 1 0 -0.5" album="Starter" material="cement" texgens="-1 0 0 16 0 0 -1 -128 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 2 4 5 3" />
                        </Face>
                        <Face id="1124" plane="1 0 -0 -0.5" album="Starter" material="cement" texgens="0 1 0 16 0 0 -1 -128 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 4 2 1 6" />
                        </Face>
                        <Face id="1125" plane="-1 -0 -0 0" album="Starter" material="cement9" texgens="0 -1 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 3 5 7 0" />
                        </Face>
                        <Face id="1126" plane="0 -1 0 -0" album="Starter" material="cement9" texgens="-1 0 0 16 0 0 1 -128 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 6 1 0 7" />
                        </Face>
                        <Face id="1127" plane="-0 0 1 -1.92" album="Starter" material="cement" texgens="-0.5 0 0 256 0 -1 0 -224 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="247" owner="0" type="0" pos="-40 50 7.5" rot="1 0 0 0" scale="" transform="1 0 0 -40 0 1 0 50 0 0 1.25 7.5 0 0 0 1" group="2" locked="0" nextFaceID="1143" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0 0 0.4" />
                            <Vertex pos="0 -0.5 0.4" />
                            <Vertex pos="0.5 -0.5 0.4" />
                            <Vertex pos="0.5 0 0.4" />
                            <Vertex pos="0.5 -0.5 1.92" />
                            <Vertex pos="0 -0.5 1.92" />
                            <Vertex pos="0.5 0 1.92" />
                            <Vertex pos="0 0 1.92" />
                        </Vertices>
                        <Face id="1136" plane="0 0 -1 0.4" album="Starter" material="cement9" texgens="0 1 0 16 1 0 0 -128 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="1137" plane="0 -1 0 -0.5" album="Starter" material="cement" texgens="1 0 0 16 0 0 -1 -128 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 4 2 1 5" />
                        </Face>
                        <Face id="1138" plane="1 -0 0 -0.5" album="Starter" material="cement" texgens="0 1 0 16 0 0 -1 -128 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 2 4 6 3" />
                        </Face>
                        <Face id="1139" plane="-1 0 0 -0" album="Starter" material="cement9" texgens="0 -1 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 5 1 0 7" />
                        </Face>
                        <Face id="1140" plane="0 1 0 -0" album="Starter" material="cement9" texgens="-1 0 0 16 0 0 1 -128 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 7 0 3 6" />
                        </Face>
                        <Face id="1141" plane="0 0 1 -1.92" album="Starter" material="cement" texgens="-0.5 0 0 256 0 -1 0 -224 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="250" owner="0" type="0" pos="0.25 30.25 5.25" rot="1 0 0 0" scale="" transform="1 0 0 0.25 0 1 0 30.25 0 0 1 5.25 0 0 0 1" group="-1" locked="0" nextFaceID="4387" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.25 -30.25 -5.25" />
                            <Vertex pos="0.25 -30.25 -5.25" />
                            <Vertex pos="0.25 -26.25 -5.25" />
                            <Vertex pos="-0.25 -26.25 -5.25" />
                            <Vertex pos="-0.25 -30.25 5.65" />
                            <Vertex pos="0.25 -30.25 5.65" />
                            <Vertex pos="0.25 -26.25 5.65" />
                            <Vertex pos="-0.25 -26.25 5.65" />
                        </Vertices>
                        <Face id="4380" plane="0 0 -1 -5.25" album="Starter" material="cement" texgens="-1 0 0 8 0 -1 0 -968 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="4381" plane="0 -1 0 -30.25" album="Starter" material="cement" texgens="1 0 0 8 0 0 -1 -168 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 0 4 5 1" />
                        </Face>
                        <Face id="4382" plane="1 -0 0 -0.25" album="Starter" material="cement" texgens="0 1 0 968 0 0 -1 -168 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 1 5 6 2" />
                        </Face>
                        <Face id="4383" plane="-1 0 0 -0.25" album="Starter" material="cement" texgens="0 -1 0 968 0 0 -1 -168 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 0 3 7 4" />
                        </Face>
                        <Face id="4384" plane="0 1 0 26.25" album="Starter" material="cement" texgens="1 0 0 27.2 0 0 -1 -152 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="4385" plane="0 0 1 -5.65" album="Starter" material="cement" texgens="-1 0 0 8 0 -1 0 -984 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="251" owner="0" type="0" pos="0.25 30.25 5.25" rot="1 0 0 0" scale="" transform="1 0 0 0.25 0 1 0 30.25 0 0 1 5.25 0 0 0 1" group="-1" locked="0" nextFaceID="4393" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.25 -26.25 -1.75" />
                            <Vertex pos="0.25 -26.25 -1.75" />
                            <Vertex pos="0.25 -24.25 -1.75" />
                            <Vertex pos="-0.25 -24.25 -1.75" />
                            <Vertex pos="-0.25 -24.25 5.65" />
                            <Vertex pos="0.25 -24.25 5.65" />
                            <Vertex pos="0.25 -26.25 5.65" />
                            <Vertex pos="-0.25 -26.25 5.65" />
                        </Vertices>
                        <Face id="4386" plane="0 0 -1 -1.75" album="Starter" material="cement" texgens="1 0 0 27.2 0 -1 0 -840 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="4387" plane="0 1 0 24.25" album="Starter" material="cement" texgens="-1 0 0 11.2 0 0 -1 -152 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 4 3 2 5" />
                        </Face>
                        <Face id="4388" plane="1 0 -0 -0.25" album="Starter" material="cement" texgens="0 1 0 968 0 0 -1 -168 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 5 2 1 6" />
                        </Face>
                        <Face id="4389" plane="-1 -0 -0 -0.25" album="Starter" material="cement" texgens="0 -1 0 968 0 0 -1 -168 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 3 4 7 0" />
                        </Face>
                        <Face id="4390" plane="0 -1 0 -26.25" album="Starter" material="cement" texgens="1 0 0 27.2 0 0 -1 -152 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 6 1 0 7" />
                        </Face>
                        <Face id="4391" plane="-0 0 1 -5.65" album="Starter" material="cement" texgens="-1 0 0 8 0 -1 0 -984 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="252" owner="0" type="0" pos="0.25 30.25 5.25" rot="1 0 0 0" scale="" transform="1 0 0 0.25 0 1 0 30.25 0 0 1 5.25 0 0 0 1" group="-1" locked="0" nextFaceID="4387" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 28.35 -5.25" />
                            <Vertex pos="0.25 40.25 -5.25" />
                            <Vertex pos="-0.25 40.25 -5.25" />
                            <Vertex pos="-0.25 28.35 -5.25" />
                            <Vertex pos="0.25 40.25 5.65" />
                            <Vertex pos="-0.25 40.25 5.65" />
                            <Vertex pos="0.25 28.35 5.65" />
                            <Vertex pos="-0.25 28.35 5.65" />
                        </Vertices>
                        <Face id="4380" plane="-0 -0 -1 -5.25" album="Starter" material="cement" texgens="-1 0 0 8 0 -1 0 -968 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="4381" plane="0 1 -0 -40.25" album="Starter" material="cement" texgens="-1 0 0 8 0 0 -1 -168 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 2 1 4 5" />
                        </Face>
                        <Face id="4382" plane="1 0 -0 -0.25" album="Starter" material="cement" texgens="0 1 0 968 0 0 -1 -168 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 4 1 0 6" />
                        </Face>
                        <Face id="4383" plane="-1 0 0 -0.25" album="Starter" material="cement" texgens="0 -1 0 968 0 0 -1 -168 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 3 2 5 7" />
                        </Face>
                        <Face id="4384" plane="0 -1 0 28.35" album="Starter" material="cement" texgens="-1 0 0 11.2 0 0 -1 -152 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 6 0 3 7" />
                        </Face>
                        <Face id="4385" plane="-0 0 1 -5.65" album="Starter" material="cement" texgens="-1 0 0 8 0 -1 0 -984 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="253" owner="0" type="0" pos="0.25 30.25 5.25" rot="1 0 0 0" scale="" transform="1 0 0 0.25 0 1 0 30.25 0 0 1 5.25 0 0 0 1" group="-1" locked="0" nextFaceID="4393" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 -24.25 -5.25" />
                            <Vertex pos="0.25 26.35 -5.25" />
                            <Vertex pos="-0.25 26.35 -5.25" />
                            <Vertex pos="-0.25 -24.25 -5.25" />
                            <Vertex pos="0.25 -24.25 5.65" />
                            <Vertex pos="-0.25 -24.25 5.65" />
                            <Vertex pos="0.25 26.35 5.65" />
                            <Vertex pos="-0.25 26.35 5.65" />
                        </Vertices>
                        <Face id="4386" plane="-0 -0 -1 -5.25" album="Starter" material="cement" texgens="-1 0 0 8 0 -1 0 -968 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="4387" plane="0 -1 0 -24.25" album="Starter" material="cement" texgens="-1 0 0 11.2 0 0 -1 -152 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 4 0 3 5" />
                        </Face>
                        <Face id="4388" plane="1 0 -0 -0.25" album="Starter" material="cement" texgens="0 1 0 968 0 0 -1 -168 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 6 1 0 4" />
                        </Face>
                        <Face id="4389" plane="-1 0 0 -0.25" album="Starter" material="cement" texgens="0 -1 0 968 0 0 -1 -168 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 3 2 7 5" />
                        </Face>
                        <Face id="4390" plane="0 1 0 -26.35" album="Starter" material="cement" texgens="1 0 0 27.2 0 0 -1 -152 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 7 2 1 6" />
                        </Face>
                        <Face id="4391" plane="0 0 1 -5.65" album="Starter" material="cement" texgens="-1 0 0 8 0 -1 0 -984 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="254" owner="0" type="0" pos="0.25 30.25 5.25" rot="1 0 0 0" scale="" transform="1 0 0 0.25 0 1 0 30.25 0 0 1 5.25 0 0 0 1" group="-1" locked="0" nextFaceID="4399" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.25 26.35 -1.75" />
                            <Vertex pos="0.25 26.35 -1.75" />
                            <Vertex pos="0.25 28.35 -1.75" />
                            <Vertex pos="-0.25 28.35 -1.75" />
                            <Vertex pos="-0.25 28.35 5.65" />
                            <Vertex pos="0.25 28.35 5.65" />
                            <Vertex pos="0.25 26.35 5.65" />
                            <Vertex pos="-0.25 26.35 5.65" />
                        </Vertices>
                        <Face id="4392" plane="0 0 -1 -1.75" album="Starter" material="cement" texgens="1 0 0 27.2 0 -1 0 843.2 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="4393" plane="0 1 0 -28.35" album="Starter" material="cement" texgens="-1 0 0 11.2 0 0 -1 -152 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 4 3 2 5" />
                        </Face>
                        <Face id="4394" plane="1 0 -0 -0.25" album="Starter" material="cement" texgens="0 1 0 968 0 0 -1 -168 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 5 2 1 6" />
                        </Face>
                        <Face id="4395" plane="-1 -0 -0 -0.25" album="Starter" material="cement" texgens="0 -1 0 968 0 0 -1 -168 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 3 4 7 0" />
                        </Face>
                        <Face id="4396" plane="0 -1 0 26.35" album="Starter" material="cement" texgens="1 0 0 27.2 0 0 -1 -152 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 6 1 0 7" />
                        </Face>
                        <Face id="4397" plane="-0 0 1 -5.65" album="Starter" material="cement" texgens="-1 0 0 8 0 -1 0 -984 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="257" owner="0" type="0" pos="-60.25 30 5.25" rot="1 0 0 0" scale="" transform="1 0 0 -60.25 0 1 0 30 0 0 1 5.25 0 0 0 1" group="-1" locked="0" nextFaceID="5445" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.25 -30 -5.25" />
                            <Vertex pos="0.25 -30 -5.25" />
                            <Vertex pos="0.25 40 -5.25" />
                            <Vertex pos="-0.25 40 -5.25" />
                            <Vertex pos="0.25 -30 5.65" />
                            <Vertex pos="0.25 40 5.65" />
                            <Vertex pos="-0.25 40 5.65" />
                            <Vertex pos="-0.25 -30 5.65" />
                        </Vertices>
                        <Face id="5438" plane="0 0 -1 -5.25" album="Starter" material="cement" texgens="-1 0 0 8 0 -1 0 -960 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="5439" plane="1 -0 0 -0.25" album="Starter" material="cement" texgens="0 1 0 960 0 0 -1 -168 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="5440" plane="-1 0 0 -0.25" album="Starter" material="cement" texgens="0 -1 0 960 0 0 -1 -168 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 0 3 6 7" />
                        </Face>
                        <Face id="5441" plane="0 1 -0 -40" album="Starter" material="cement" texgens="-1 0 0 8 0 0 -1 -168 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 3 2 5 6" />
                        </Face>
                        <Face id="5442" plane="0 -1 0 -30" album="Starter" material="cement" texgens="1 0 0 8 0 0 -1 -168 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="5443" plane="-0 0 1 -5.65" album="Starter" material="cement" texgens="-1 0 0 1944 0 -1 0 -976 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="258" owner="0" type="0" pos="-30 -0.25 5.25" rot="1 0 0 0" scale="" transform="1 0 0 -30 0 1 0 -0.25 0 0 1 5.25 0 0 0 1" group="-1" locked="0" nextFaceID="4045" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-30.5 -0.25 4.65" />
                            <Vertex pos="-11 -0.25 4.65" />
                            <Vertex pos="-11 0.25 4.65" />
                            <Vertex pos="-30.5 0.25 4.65" />
                            <Vertex pos="-30.5 0.25 5.65" />
                            <Vertex pos="-30.5 -0.25 5.65" />
                            <Vertex pos="-11 0.25 5.65" />
                            <Vertex pos="-11 -0.25 5.65" />
                        </Vertices>
                        <Face id="4038" plane="0 0 -1 4.65" album="Starter" material="cement" texgens="-0.5 0 0 96 0 -1 0 1384 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="4039" plane="-1 -0 -0 -30.5" album="Starter" material="cement" texgens="0 -1 0 8 0 0 -1 -168 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 3 4 5 0" />
                        </Face>
                        <Face id="4040" plane="0 1 0 -0.25" album="Starter" material="cement" texgens="-1 0 0 976 0 0 -1 -168 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 4 3 2 6" />
                        </Face>
                        <Face id="4041" plane="0 -1 0 -0.25" album="Starter" material="cement" texgens="1 0 0 976 0 0 -1 -168 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 0 5 7 1" />
                        </Face>
                        <Face id="4042" plane="1 -0 0 11" album="Starter" material="cement" texgens="0 1 0 -872 0 0 0.375 190.6 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 1 7 6 2" />
                        </Face>
                        <Face id="4043" plane="0 0 1 -5.65" album="Starter" material="cement" texgens="-1 0 0 976 0 -1 0 -8 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="259" owner="0" type="0" pos="-30.25 70.25 5.25" rot="1 0 0 0" scale="" transform="1 0 0 -30.25 0 1 0 70.25 0 0 1 5.25 0 0 0 1" group="-1" locked="0" nextFaceID="4411" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-10.75 0.25 4.65" />
                            <Vertex pos="-30.25 0.25 4.65" />
                            <Vertex pos="-30.25 -0.25 4.65" />
                            <Vertex pos="-10.75 -0.25 4.65" />
                            <Vertex pos="-30.25 0.25 5.65" />
                            <Vertex pos="-30.25 -0.25 5.65" />
                            <Vertex pos="-10.75 0.25 5.65" />
                            <Vertex pos="-10.75 -0.25 5.65" />
                        </Vertices>
                        <Face id="4404" plane="0 0 -1 4.65" album="Starter" material="cement" texgens="-0.5 0 0 100 0 -1 0 -872 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="4405" plane="-1 -0 -0 -30.25" album="Starter" material="cement" texgens="0 -1 0 8 0 0 -1 -168 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="4406" plane="0 1 0 -0.25" album="Starter" material="cement" texgens="-1 0 0 968 0 0 -1 -168 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 4 1 0 6" />
                        </Face>
                        <Face id="4407" plane="0 -1 0 -0.25" album="Starter" material="cement" texgens="1 0 0 968 0 0 -1 -168 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 2 5 7 3" />
                        </Face>
                        <Face id="4408" plane="1 -0 0 10.75" album="Starter" material="cement" texgens="0 1 0 1384 0 0 0.375 190.6 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 3 7 6 0" />
                        </Face>
                        <Face id="4409" plane="0 0 1 -5.65" album="Starter" material="cement" texgens="-1 0 0 984 0 -1 0 -2264 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="263" owner="0" type="0" pos="-30 70.25 5.3" rot="1 0 0 0" scale="" transform="1 0 0 -30 0 1 0 70.25 0 0 1 5.3 0 0 0 1" group="-1" locked="0" nextFaceID="2005" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-7 0.25 3.8" />
                            <Vertex pos="-7 0.25 5.1" />
                            <Vertex pos="-7 -0.25 5.1" />
                            <Vertex pos="-7 -0.25 3.8" />
                            <Vertex pos="9 0.25 5.1" />
                            <Vertex pos="9 -0.25 5.1" />
                            <Vertex pos="9 0.25 3.8" />
                            <Vertex pos="9 -0.25 3.8" />
                        </Vertices>
                        <Face id="1998" plane="-1 -0 -0 -7" album="TGEDemo" material="Mtl" texgens="0 -1 0 8 0 0 -1 -169.6 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="1999" plane="0 0 1 -5.1" album="Starter" material="cement10" texgens="1 0 0 320 0 -1 0 -8 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="2000" plane="-0 1 0 -0.25" album="Starter" material="cement10" texgens="-1 0 0 320 0 0 -1 -163.2 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 4 1 0 6" />
                        </Face>
                        <Face id="2001" plane="-0 -1 -0 -0.25" album="Starter" material="cement10" texgens="1 0 0 320 0 0 -1 -163.2 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 2 5 7 3" />
                        </Face>
                        <Face id="2002" plane="0 0 -1 3.8" album="TGEDemo" material="Mtl" texgens="1 0 0 224 0 -1 0 -8 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 7 6 0" />
                        </Face>
                        <Face id="2003" plane="1 -0 0 -9" album="Starter" material="cement" texgens="0 -1 0 11.2 0 0 -1 140.8 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="264" owner="0" type="0" pos="-30 70.25 5.3" rot="1 0 0 0" scale="" transform="1 0 0 -30 0 1 0 70.25 0 0 1 5.3 0 0 0 1" group="-1" locked="0" nextFaceID="2011" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="9 -0.25 3.8" />
                            <Vertex pos="10 -0.25 3.8" />
                            <Vertex pos="10 0.25 3.8" />
                            <Vertex pos="9 0.25 3.8" />
                            <Vertex pos="10 -0.25 4.4" />
                            <Vertex pos="10 0.25 4.4" />
                            <Vertex pos="9 0.25 4.4" />
                            <Vertex pos="9 -0.25 4.4" />
                        </Vertices>
                        <Face id="2004" plane="0 0 -1 3.8" album="Starter" material="cement" texgens="1 0 0 224 0 -1 0 -8 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="2005" plane="1 -0 0 -10" album="Starter" material="cement" texgens="0 1 0 8 0 0 -1 -163.2 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="2006" plane="0 1 0 -0.25" album="Starter" material="cement" texgens="-1 0 0 320 0 0 -1 -163.2 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 2 5 6 3" />
                        </Face>
                        <Face id="2007" plane="0 -1 0 -0.25" album="Starter" material="cement" texgens="1 0 0 320 0 0 -1 -163.2 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 4 1 0 7" />
                        </Face>
                        <Face id="2008" plane="-1 0 0 9" album="Starter" material="cement" texgens="0 -1 0 11.2 0 0 -1 140.8 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 0 3 6 7" />
                        </Face>
                        <Face id="2009" plane="-0 0 1 -4.4" album="Starter" material="cement" texgens="-1 0 0 352 0 -1 0 -2267.2 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="265" owner="0" type="0" pos="-20 10 7.5" rot="1 0 0 0" scale="" transform="1 0 0 -20 0 1 0 10 0 0 1.25 7.5 0 0 0 1" group="-1" locked="0" nextFaceID="3649" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.5 -0.5 -4" />
                            <Vertex pos="0.5 -0.5 -4" />
                            <Vertex pos="0.5 0.5 -4" />
                            <Vertex pos="-0.5 0.5 -4" />
                            <Vertex pos="0.5 -0.5 1.76" />
                            <Vertex pos="0.5 0.5 1.76" />
                            <Vertex pos="-0.5 0.5 1.76" />
                            <Vertex pos="-0.5 -0.5 1.76" />
                        </Vertices>
                        <Face id="3642" plane="0 0 -1 -4" album="Starter" material="cement" texgens="-1 0 0 16 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="3643" plane="1 -0 0 -0.5" album="Starter" material="cement" texgens="0 1 0 16 0 0 -1 -128 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="3644" plane="-1 0 0 -0.5" album="Starter" material="cement" texgens="0 -1 0 16 0 0 -1 -128 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 0 3 6 7" />
                        </Face>
                        <Face id="3645" plane="0 1 -0 -0.5" album="Starter" material="cement" texgens="-1 0 0 16 0 0 -1 -128 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 3 2 5 6" />
                        </Face>
                        <Face id="3646" plane="0 -1 0 -0.5" album="Starter" material="cement" texgens="1 0 0 16 0 0 -1 -128 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="3647" plane="-0 0 1 -1.76" album="Starter" material="cement" texgens="-1 0 0 32 0 -1 0 -339.2 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="266" owner="0" type="0" pos="-20 30 7.5" rot="1 0 0 0" scale="" transform="1 0 0 -20 0 1 0 30 0 0 1.25 7.5 0 0 0 1" group="-1" locked="0" nextFaceID="1111" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.5 -0.5 -4" />
                            <Vertex pos="0.5 -0.5 -4" />
                            <Vertex pos="0.5 0.5 -4" />
                            <Vertex pos="-0.5 0.5 -4" />
                            <Vertex pos="0.5 -0.5 1.76" />
                            <Vertex pos="0.5 0.5 1.76" />
                            <Vertex pos="-0.5 0.5 1.76" />
                            <Vertex pos="-0.5 -0.5 1.76" />
                        </Vertices>
                        <Face id="1104" plane="0 0 -1 -4" album="Starter" material="cement" texgens="-1 0 0 16 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="1105" plane="1 -0 0 -0.5" album="Starter" material="cement" texgens="0 1 0 16 0 0 -1 -128 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="1106" plane="-1 0 0 -0.5" album="Starter" material="cement" texgens="0 -1 0 16 0 0 -1 -128 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 0 3 6 7" />
                        </Face>
                        <Face id="1107" plane="0 1 -0 -0.5" album="Starter" material="cement" texgens="-1 0 0 16 0 0 -1 -128 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 3 2 5 6" />
                        </Face>
                        <Face id="1108" plane="0 -1 0 -0.5" album="Starter" material="cement" texgens="1 0 0 16 0 0 -1 -128 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="1109" plane="-0 0 1 -1.76" album="Starter" material="cement" texgens="-1 0 0 32 0 -1 0 -979.2 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="267" owner="0" type="0" pos="-20 50 7.5" rot="1 0 0 0" scale="" transform="1 0 0 -20 0 1 0 50 0 0 1.25 7.5 0 0 0 1" group="-1" locked="0" nextFaceID="811" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.5 -0.5 1.10138" />
                            <Vertex pos="0.5 -0.5 0.854846" />
                            <Vertex pos="0.5 0.5 0.854861" />
                            <Vertex pos="-0.5 0.5 1.10139" />
                            <Vertex pos="0.5 -0.5 1.76" />
                            <Vertex pos="0.5 0.5 1.76" />
                            <Vertex pos="-0.5 0.5 1.76" />
                            <Vertex pos="-0.5 -0.5 1.76" />
                        </Vertices>
                        <Face id="804" plane="-0.239367 1.45837e-005 -0.970929 0.949686" album="Starter" material="cement9" texgens="0 0.239365 0 16 -0.232407 0 0.0572956 -128 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="805" plane="1 -0 0 -0.5" album="Starter" material="cement" texgens="0 1 0 16 0 0 -1 -128 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="806" plane="-1 -0 -0 -0.5" album="Starter" material="cement" texgens="0 -1 0 16 0 0 -1 -128 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 3 6 7 0" />
                        </Face>
                        <Face id="807" plane="0 1 0 -0.5" album="Starter" material="cement" texgens="-1 0 0 16 0 0 -1 -128 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 2 5 6 3" />
                        </Face>
                        <Face id="808" plane="0 -1 0 -0.5" album="Starter" material="cement" texgens="1 0 0 16 0 0 -1 -128 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="809" plane="-0 0 1 -1.76" album="Starter" material="cement" texgens="-1 0 0 32 0 -1 0 -1619.2 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="268" owner="0" type="0" pos="-30 -0.25 5.25" rot="1 0 0 0" scale="" transform="1 0 0 -30 0 1 0 -0.25 0 0 1 5.25 0 0 0 1" group="-1" locked="0" nextFaceID="4033" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-30.5 -0.25 -5.25" />
                            <Vertex pos="-30.5 0.25 -5.25" />
                            <Vertex pos="-30.5 0.25 4.65" />
                            <Vertex pos="-30.5 -0.25 4.65" />
                            <Vertex pos="9 -0.25 -5.25" />
                            <Vertex pos="9 0.25 -5.25" />
                            <Vertex pos="9 0.25 4.65" />
                            <Vertex pos="9 -0.25 4.65" />
                        </Vertices>
                        <Face id="4026" plane="-1 0 0 -30.5" album="Starter" material="cement" texgens="0 -1 0 8 0 0 -1 -168 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="4027" plane="0 0 -1 -5.25" album="Starter" material="cement" texgens="-1 0 0 976 0 -1 0 -8 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 0 4 5 1" />
                        </Face>
                        <Face id="4028" plane="0 1 -0 -0.25" album="Starter" material="cement" texgens="-1 0 0 976 0 0 -1 -168 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 1 5 6 2" />
                        </Face>
                        <Face id="4029" plane="0 -1 0 -0.25" album="Starter" material="cement" texgens="1 0 0 976 0 0 -1 -168 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 0 3 7 4" />
                        </Face>
                        <Face id="4030" plane="-0 0 1 -4.65" album="Starter" material="cement" texgens="-0.5 0 0 96 0 -1 0 1384 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 3 2 6 7" />
                        </Face>
                        <Face id="4031" plane="1 0 0 -9" album="Starter" material="cement" texgens="0 -1 0 2267.2 0 0 -1 142.4 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="269" owner="0" type="0" pos="-30 -0.25 5.25" rot="1 0 0 0" scale="" transform="1 0 0 -30 0 1 0 -0.25 0 0 1 5.25 0 0 0 1" group="-1" locked="0" nextFaceID="4039" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="9 -0.25 -5.25" />
                            <Vertex pos="30.5 -0.25 -5.25" />
                            <Vertex pos="30.5 0.25 -5.25" />
                            <Vertex pos="9 0.25 -5.25" />
                            <Vertex pos="30.5 -0.25 4.45" />
                            <Vertex pos="30.5 0.25 4.45" />
                            <Vertex pos="9 0.25 4.45" />
                            <Vertex pos="9 -0.25 4.45" />
                        </Vertices>
                        <Face id="4032" plane="0 0 -1 -5.25" album="Starter" material="cement" texgens="-1 0 0 976 0 -1 0 -8 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="4033" plane="1 -0 0 -30.5" album="Starter" material="cement" texgens="0 1 0 8 0 0 -1 -168 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="4034" plane="0 1 -0 -0.25" album="Starter" material="cement" texgens="-1 0 0 976 0 0 -1 -168 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 3 2 5 6" />
                        </Face>
                        <Face id="4035" plane="0 -1 0 -0.25" album="Starter" material="cement" texgens="1 0 0 976 0 0 -1 -168 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 4 1 0 7" />
                        </Face>
                        <Face id="4036" plane="-1 0 0 9" album="Starter" material="cement" texgens="0 -1 0 2267.2 0 0 -1 142.4 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 7 0 3 6" />
                        </Face>
                        <Face id="4037" plane="-0 0 1 -4.45" album="Starter" material="cement" texgens="-1 0 0 352 0 -1 0 -11.2 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="270" owner="0" type="0" pos="-30 -0.25 5.25" rot="1 0 0 0" scale="" transform="1 0 0 -30 0 1 0 -0.25 0 0 1 5.25 0 0 0 1" group="-1" locked="0" nextFaceID="4045" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="30.5 -0.25 4.45" />
                            <Vertex pos="30.5 -0.25 4.65" />
                            <Vertex pos="30.5 0.25 4.65" />
                            <Vertex pos="30.5 0.25 4.45" />
                            <Vertex pos="11 0.25 4.65" />
                            <Vertex pos="11 -0.25 4.65" />
                            <Vertex pos="11 0.25 4.45" />
                            <Vertex pos="11 -0.25 4.45" />
                        </Vertices>
                        <Face id="4038" plane="1 -0 0 -30.5" album="Starter" material="cement" texgens="0 1 0 8 0 0 -1 -168 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="4039" plane="0 0 1 -4.65" album="Starter" material="cement" texgens="-0.5 0 0 96 0 -1 0 1384 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 4 2 1 5" />
                        </Face>
                        <Face id="4040" plane="0 1 0 -0.25" album="Starter" material="cement" texgens="-1 0 0 976 0 0 -1 -168 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 3 2 4 6" />
                        </Face>
                        <Face id="4041" plane="-0 -1 -0 -0.25" album="Starter" material="cement" texgens="1 0 0 976 0 0 -1 -168 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 5 1 0 7" />
                        </Face>
                        <Face id="4042" plane="0 0 -1 4.45" album="Starter" material="cement" texgens="-1 0 0 352 0 -1 0 -11.2 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 7 0 3 6" />
                        </Face>
                        <Face id="4043" plane="-1 0 0 11" album="Starter" material="cement" texgens="0 1 0 11.2 0 0 -1 142.4 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="271" owner="0" type="0" pos="-30.25 70.25 5.25" rot="1 0 0 0" scale="" transform="1 0 0 -30.25 0 1 0 70.25 0 0 1 5.25 0 0 0 1" group="-1" locked="0" nextFaceID="4417" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="10.25 -0.25 -4.75" />
                            <Vertex pos="30.25 -0.25 -4.75" />
                            <Vertex pos="30.25 0.25 -4.75" />
                            <Vertex pos="10.25 0.25 -4.75" />
                            <Vertex pos="30.25 -0.25 4.45" />
                            <Vertex pos="30.25 0.25 4.45" />
                            <Vertex pos="10.25 0.25 4.45" />
                            <Vertex pos="10.25 -0.25 4.45" />
                        </Vertices>
                        <Face id="4410" plane="0 0 -1 -4.75" album="Starter" material="cement" texgens="1 0 0 312 0 -1 0 -328 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="4411" plane="1 -0 0 -30.25" album="Starter" material="cement" texgens="0 1 0 8 0 0 -1 -168 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="4412" plane="0 1 0 -0.25" album="Starter" material="cement" texgens="-1 0 0 968 0 0 -1 -168 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 2 5 6 3" />
                        </Face>
                        <Face id="4413" plane="0 -1 0 -0.25" album="Starter" material="cement" texgens="1 0 0 968 0 0 -1 -168 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 4 1 0 7" />
                        </Face>
                        <Face id="4414" plane="-1 0 0 10.25" album="Starter" material="cement" texgens="0 0 -1 164.8 0 -1.90909 0 -15.2725 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 0 3 6 7" />
                        </Face>
                        <Face id="4415" plane="-0 0 1 -4.45" album="Starter" material="cement" texgens="-1 0 0 360 0 -1 0 -2267.2 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="272" owner="0" type="0" pos="-30.25 70.25 5.25" rot="1 0 0 0" scale="" transform="1 0 0 -30.25 0 1 0 70.25 0 0 1 5.25 0 0 0 1" group="-1" locked="0" nextFaceID="4423" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="30.25 -0.25 4.45" />
                            <Vertex pos="30.25 -0.25 5.65" />
                            <Vertex pos="30.25 0.25 5.65" />
                            <Vertex pos="30.25 0.25 4.45" />
                            <Vertex pos="11.25 0.25 5.65" />
                            <Vertex pos="11.25 -0.25 5.65" />
                            <Vertex pos="11.25 0.25 4.45" />
                            <Vertex pos="11.25 -0.25 4.45" />
                        </Vertices>
                        <Face id="4416" plane="1 -0 0 -30.25" album="Starter" material="cement" texgens="0 1 0 8 0 0 -1 -168 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="4417" plane="0 0 1 -5.65" album="Starter" material="cement" texgens="-1 0 0 984 0 -1 0 -2264 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 4 2 1 5" />
                        </Face>
                        <Face id="4418" plane="0 1 0 -0.25" album="Starter" material="cement" texgens="-1 0 0 968 0 0 -1 -168 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 3 2 4 6" />
                        </Face>
                        <Face id="4419" plane="0 -1 0 -0.25" album="Starter" material="cement" texgens="1 0 0 968 0 0 -1 -168 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 1 0 7 5" />
                        </Face>
                        <Face id="4420" plane="0 0 -1 4.45" album="Starter" material="cement" texgens="-1 0 0 360 0 -1 0 -2267.2 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 7 0 3 6" />
                        </Face>
                        <Face id="4421" plane="-1 0 0 11.25" album="Starter" material="cement" texgens="0 1 0 2267.2 0 0 -1 142.4 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="273" owner="0" type="0" pos="-30 -0.25 5.25" rot="1 0 0 0" scale="" transform="1 0 0 -30 0 1 0 -0.25 0 0 1 5.25 0 0 0 1" group="-1" locked="0" nextFaceID="4045" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-9 -0.25 4.65" />
                            <Vertex pos="-9 0.25 4.65" />
                            <Vertex pos="-9 0.25 5.65" />
                            <Vertex pos="-9 -0.25 5.65" />
                            <Vertex pos="9 -0.25 4.65" />
                            <Vertex pos="9 0.25 4.65" />
                            <Vertex pos="9 0.25 5.65" />
                            <Vertex pos="9 -0.25 5.65" />
                        </Vertices>
                        <Face id="4038" plane="-1 0 0 -9" album="Starter" material="cement" texgens="0 1 0 -872 0 0 0.375 190.6 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="4039" plane="0 0 -1 4.65" album="Starter" material="cement" texgens="-0.5 0 0 96 0 -1 0 1384 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 0 4 5 1" />
                        </Face>
                        <Face id="4040" plane="-0 1 0 -0.25" album="Starter" material="cement" texgens="-1 0 0 976 0 0 -1 -168 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 6 2 1 5" />
                        </Face>
                        <Face id="4041" plane="0 -1 0 -0.25" album="Starter" material="cement" texgens="1 0 0 976 0 0 -1 -168 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 4 0 3 7" />
                        </Face>
                        <Face id="4042" plane="-0 0 1 -5.65" album="Starter" material="cement" texgens="-1 0 0 976 0 -1 0 -8 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 3 2 6 7" />
                        </Face>
                        <Face id="4043" plane="1 0 0 -9" album="Starter" material="cement" texgens="0 -1 0 2267.2 0 0 -1 142.4 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="274" owner="0" type="0" pos="-30 -0.25 5.25" rot="1 0 0 0" scale="" transform="1 0 0 -30 0 1 0 -0.25 0 0 1 5.25 0 0 0 1" group="-1" locked="0" nextFaceID="4051" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="30.5 -0.25 4.65" />
                            <Vertex pos="30.5 -0.25 5.65" />
                            <Vertex pos="30.5 0.25 5.65" />
                            <Vertex pos="30.5 0.25 4.65" />
                            <Vertex pos="11 -0.25 4.65" />
                            <Vertex pos="11 0.25 4.65" />
                            <Vertex pos="11 0.25 5.65" />
                            <Vertex pos="11 -0.25 5.65" />
                        </Vertices>
                        <Face id="4044" plane="1 -0 0 -30.5" album="Starter" material="cement" texgens="0 1 0 8 0 0 -1 -168 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="4045" plane="0 0 -1 4.65" album="Starter" material="cement" texgens="-0.5 0 0 96 0 -1 0 1384 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 4 0 3 5" />
                        </Face>
                        <Face id="4046" plane="0 1 0 -0.25" album="Starter" material="cement" texgens="-1 0 0 976 0 0 -1 -168 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 3 2 6 5" />
                        </Face>
                        <Face id="4047" plane="0 -1 0 -0.25" album="Starter" material="cement" texgens="1 0 0 976 0 0 -1 -168 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 1 0 4 7" />
                        </Face>
                        <Face id="4048" plane="0 0 1 -5.65" album="Starter" material="cement" texgens="-1 0 0 976 0 -1 0 -8 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 6 2 1 7" />
                        </Face>
                        <Face id="4049" plane="-1 0 0 11" album="Starter" material="cement" texgens="0 1 0 11.2 0 0 -1 142.4 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="275" owner="0" type="0" pos="-30.25 70.25 5.25" rot="1 0 0 0" scale="" transform="1 0 0 -30.25 0 1 0 70.25 0 0 1 5.25 0 0 0 1" group="-1" locked="0" nextFaceID="4429" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-8.75 -0.25 5.15" />
                            <Vertex pos="-8.75 0.25 5.15" />
                            <Vertex pos="-8.75 0.25 5.65" />
                            <Vertex pos="-8.75 -0.25 5.65" />
                            <Vertex pos="9.25 0.25 5.15" />
                            <Vertex pos="9.25 -0.25 5.15" />
                            <Vertex pos="9.25 0.25 5.65" />
                            <Vertex pos="9.25 -0.25 5.65" />
                        </Vertices>
                        <Face id="4422" plane="-1 0 0 -8.75" album="Starter" material="cement" texgens="0 1 0 1384 0 0 0.375 190.6 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="4423" plane="0 0 -1 5.15" album="Starter" material="cement" texgens="1 0 0 312 0 -1.90909 0 -15.2725 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 4 1 0 5" />
                        </Face>
                        <Face id="4424" plane="0 1 0 -0.25" album="Starter" material="cement" texgens="-1 0 0 968 0 0 -1 -168 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 2 1 4 6" />
                        </Face>
                        <Face id="4425" plane="0 -1 0 -0.25" album="Starter" material="cement" texgens="1 0 0 968 0 0 -1 -168 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 5 0 3 7" />
                        </Face>
                        <Face id="4426" plane="-0 0 1 -5.65" album="Starter" material="cement" texgens="-1 0 0 984 0 -1 0 -2264 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 3 2 6 7" />
                        </Face>
                        <Face id="4427" plane="1 0 0 -9.25" album="Starter" material="cement" texgens="0 -1 0 11.2 0 0 -1 142.4 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="277" owner="0" type="0" pos="-55.75 62.25 2.75" rot="1 0 0 0" scale="" transform="0.607143 0 0 -55.75 0 1 0 62.25 0 0 1 2.75 0 0 0 1" group="-1" locked="0" nextFaceID="2129" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-7 -0.25 -2.25" />
                            <Vertex pos="-7 0.25 -2.25" />
                            <Vertex pos="-7 0.25 2.25" />
                            <Vertex pos="-7 -0.25 2.25" />
                            <Vertex pos="-2.55294 0.25 -2.25" />
                            <Vertex pos="-2.55294 0.25 2.25" />
                            <Vertex pos="-2.55294 -0.25 2.25" />
                            <Vertex pos="-2.55294 -0.25 -2.25" />
                        </Vertices>
                        <Face id="2122" plane="-1 0 0 -7" album="Starter" material="cement" texgens="0 -1 0 8 0 0 -1 -72 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="2123" plane="0 1 -0 -0.25" album="Starter" material="cement" texgens="-1 0 0 224 0 0 -1 -72 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="2124" plane="0 -1 0 -0.25" album="Starter" material="cement" texgens="1 0 0 224 0 0 -1 -72 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 0 3 6 7" />
                        </Face>
                        <Face id="2125" plane="-0 0 1 -2.25" album="Starter" material="cement" texgens="1 0 0 224 0 -1 0 -8 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 3 2 5 6" />
                        </Face>
                        <Face id="2126" plane="0 0 -1 -2.25" album="Starter" material="cement" texgens="-1 0 0 224 0 -1 0 -8 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="2127" plane="1 -0 0 2.55294" album="Starter" material="cement" texgens="0 -1 0 15.1434 0 0 -1 -30.4 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="278" owner="0" type="0" pos="-55.75 62.25 2.75" rot="1 0 0 0" scale="" transform="0.607143 0 0 -55.75 0 1 0 62.25 0 0 1 2.75 0 0 0 1" group="-1" locked="0" nextFaceID="2135" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-2.55294 0.25 2.25" />
                            <Vertex pos="7 0.25 2.25" />
                            <Vertex pos="7 -0.25 2.25" />
                            <Vertex pos="-2.55294 -0.25 2.25" />
                            <Vertex pos="7 -0.25 1.2554" />
                            <Vertex pos="7 0.25 1.2554" />
                            <Vertex pos="-2.55294 0.25 1.2554" />
                            <Vertex pos="-2.55294 -0.25 1.2554" />
                        </Vertices>
                        <Face id="2128" plane="0 0 1 -2.25" album="Starter" material="cement" texgens="1 0 0 224 0 -1 0 -8 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="2129" plane="1 -0 0 -7" album="Starter" material="cement" texgens="0 1 0 8 0 0 -1 -72 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 4 2 1 5" />
                        </Face>
                        <Face id="2130" plane="0 1 0 -0.25" album="Starter" material="cement" texgens="-1 0 0 224 0 0 -1 -72 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 5 1 0 6" />
                        </Face>
                        <Face id="2131" plane="-0 -1 -0 -0.25" album="Starter" material="cement" texgens="1 0 0 224 0 0 -1 -72 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 3 2 4 7" />
                        </Face>
                        <Face id="2132" plane="-1 -0 -0 -2.55294" album="Starter" material="cement" texgens="0 -1 0 15.1434 0 0 -1 -30.4 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 6 0 3 7" />
                        </Face>
                        <Face id="2133" plane="0 0 -1 1.2554" album="Starter" material="cement" texgens="0.607143 0 0 49.6 0 -1 0 -56.7437 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="279" owner="0" type="0" pos="-55.75 62.25 2.75" rot="1 0 0 0" scale="" transform="0.607143 0 0 -55.75 0 1 0 62.25 0 0 1 2.75 0 0 0 1" group="-1" locked="0" nextFaceID="2141" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-2.55294 -0.25 -2.25" />
                            <Vertex pos="7 -0.25 -2.25" />
                            <Vertex pos="7 0.25 -2.25" />
                            <Vertex pos="-2.55294 0.25 -2.25" />
                            <Vertex pos="7 -0.25 -0.95" />
                            <Vertex pos="7 0.25 -0.95" />
                            <Vertex pos="-2.55294 0.25 -0.95" />
                            <Vertex pos="-2.55294 -0.25 -0.95" />
                        </Vertices>
                        <Face id="2134" plane="0 0 -1 -2.25" album="Starter" material="cement" texgens="-1 0 0 224 0 -1 0 -8 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="2135" plane="1 -0 0 -7" album="Starter" material="cement" texgens="0 1 0 8 0 0 -1 -72 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="2136" plane="0 1 -0 -0.25" album="Starter" material="cement" texgens="-1 0 0 224 0 0 -1 -72 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 3 2 5 6" />
                        </Face>
                        <Face id="2137" plane="0 -1 0 -0.25" album="Starter" material="cement" texgens="1 0 0 224 0 0 -1 -72 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 4 1 0 7" />
                        </Face>
                        <Face id="2138" plane="-1 0 0 -2.55294" album="Starter" material="cement" texgens="0 -1 0 15.1434 0 0 -1 -30.4 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 0 3 6 7" />
                        </Face>
                        <Face id="2139" plane="-0 0 1 0.95" album="Starter" material="cement" texgens="-0.607143 0 0 97.6 0 -1 0 -56.7437 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="280" owner="0" type="0" pos="-55.75 62.25 2.75" rot="1 0 0 0" scale="" transform="0.607143 0 0 -55.75 0 1 0 62.25 0 0 1 2.75 0 0 0 1" group="-1" locked="0" nextFaceID="2147" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="7 -0.25 -0.95" />
                            <Vertex pos="7 -0.25 1.2554" />
                            <Vertex pos="7 0.25 1.2554" />
                            <Vertex pos="7 0.25 -0.95" />
                            <Vertex pos="5.02353 0.25 1.2554" />
                            <Vertex pos="5.02353 -0.25 1.2554" />
                            <Vertex pos="5.02353 0.25 -0.95" />
                            <Vertex pos="5.02353 -0.25 -0.95" />
                        </Vertices>
                        <Face id="2140" plane="1 -0 0 -7" album="Starter" material="cement" texgens="0 1 0 8 0 0 -1 -72 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="2141" plane="0 0 1 -1.2554" album="Starter" material="cement" texgens="0.607143 0 0 49.6 0 -1 0 -56.7437 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 4 2 1 5" />
                        </Face>
                        <Face id="2142" plane="0 1 0 -0.25" album="Starter" material="cement" texgens="-1 0 0 224 0 0 -1 -72 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 3 2 4 6" />
                        </Face>
                        <Face id="2143" plane="0 -1 0 -0.25" album="Starter" material="cement" texgens="1 0 0 224 0 0 -1 -72 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 1 0 7 5" />
                        </Face>
                        <Face id="2144" plane="0 0 -1 -0.95" album="Starter" material="cement" texgens="-0.607143 0 0 97.6 0 -1 0 -56.7437 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 7 0 3 6" />
                        </Face>
                        <Face id="2145" plane="-1 0 0 5.02353" album="Starter" material="cement" texgens="0 1 0 56.7437 0 0 -1 -30.4 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="282" owner="0" type="0" pos="0.3 57.6 2" rot="1 0 0 0" scale="" transform="1 0 0 0.3 0 1 0 57.6 0 0 1 2 0 0 0 1" group="-1" locked="0" nextFaceID="1153" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.2 1 1.5" />
                            <Vertex pos="0.2 1 -1.5" />
                            <Vertex pos="0.2 -1 1.5" />
                            <Vertex pos="0.2 -1 -1.5" />
                            <Vertex pos="-0.2 1 1.5" />
                            <Vertex pos="-0.2 1 -1.5" />
                            <Vertex pos="-0.2 -1 1.5" />
                            <Vertex pos="-0.2 -1 -1.5" />
                        </Vertices>
                        <Face id="1146" plane="1 -0 0 -0.2" album="Starter" material="wall4" texgens="0 1 0 32 0 0 -1 -48 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1147" plane="-1 0 0 -0.2" album="Starter" material="wall4" texgens="0 -1 0 -265.6 0 0 -1 -316.8 0 0.2 0.2" texRot="0" texScale="0.2 0.2" texDiv="512 512">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1148" plane="0 1 -0 -1" album="Starter" material="wall4" texgens="-1 0 0 6.4 0 0 -1 -48 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1149" plane="0 -1 0 -1" album="Starter" material="wall4" texgens="1 0 0 6.4 0 0 -1 -48 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1150" plane="-0 0 1 -1.5" album="Starter" material="wall4" texgens="1 0 0 6.4 0 -1 0 -32 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1151" plane="0 0 -1 -1.5" album="Starter" material="wall4" texgens="-1 0 0 6.4 0 -1 0 -32 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="285" owner="0" type="0" pos="-30 70.25 5.2" rot="1 0 0 0" scale="" transform="1 0 0 -30 0 1 0 70.25 0 0 1.01961 5.2 0 0 0 1" group="-1" locked="0" nextFaceID="2005" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-10 -0.25 -5.1" />
                            <Vertex pos="-10 0.25 -5.1" />
                            <Vertex pos="-10 0.25 4.6096" />
                            <Vertex pos="-10 -0.25 4.6096" />
                            <Vertex pos="-8.99999 -0.25 -5.1" />
                            <Vertex pos="-8.99999 0.25 -5.1" />
                            <Vertex pos="-8.99999 0.25 4.6096" />
                            <Vertex pos="-8.99999 -0.25 4.6096" />
                        </Vertices>
                        <Face id="1998" plane="-1 0 0 -10" album="Starter" material="cement" texgens="0 -1 0 8 0 0 -1 -163.2 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="1999" plane="0 0 -1 -5.1" album="Starter" material="cement" texgens="-1 0 0 320 0 -1 0 -8 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 0 4 5 1" />
                        </Face>
                        <Face id="2000" plane="0 1 -0 -0.25" album="Starter" material="cement" texgens="-1 0 0 320 0 0 -1 -163.2 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 1 5 6 2" />
                        </Face>
                        <Face id="2001" plane="0 -1 0 -0.25" album="Starter" material="cement" texgens="1 0 0 320 0 0 -1 -163.2 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 0 3 7 4" />
                        </Face>
                        <Face id="2002" plane="0 0 1 -4.6096" album="Starter" material="cement" texgens="-0.5 0 0 96 0 -1 0 -872 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="2003" plane="1 0 0 8.99999" album="Starter" material="cement" texgens="0 -1 0 320 0 0 1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="286" owner="0" type="0" pos="-30 70.25 5.2" rot="1 0 0 0" scale="" transform="1 0 0 -30 0 1 0 70.25 0 0 1.01961 5.2 0 0 0 1" group="-1" locked="0" nextFaceID="2005" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-7 -0.25 -5.1" />
                            <Vertex pos="-7 -0.25 4.6096" />
                            <Vertex pos="-7 0.25 4.6096" />
                            <Vertex pos="-7 0.25 -5.1" />
                            <Vertex pos="-8.99999 -0.25 -5.1" />
                            <Vertex pos="-8.99999 0.25 -5.1" />
                            <Vertex pos="-8.99999 0.25 4.6096" />
                            <Vertex pos="-8.99999 -0.25 4.6096" />
                        </Vertices>
                        <Face id="1998" plane="1 -0 0 7" album="TGEDemo" material="Mtl" texgens="0 -1 0 8 0 0 -1 -169.6 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="1999" plane="0 0 -1 -5.1" album="Starter" material="cement10" texgens="-1 0 0 320 0 -1 0 -8 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 4 0 3 5" />
                        </Face>
                        <Face id="2000" plane="0 1 -0 -0.25" album="Starter" material="cement10" texgens="-1 0 0 320 0 0 -1 -163.2 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 5 3 2 6" />
                        </Face>
                        <Face id="2001" plane="-0 -1 -0 -0.25" album="Starter" material="cement10" texgens="1 0 0 320 0 0 -1 -163.2 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 7 1 0 4" />
                        </Face>
                        <Face id="2002" plane="0 0 1 -4.6096" album="Starter" material="cement" texgens="-0.5 0 0 96 0 -1 0 -872 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 1 7 6 2" />
                        </Face>
                        <Face id="2003" plane="-1 0 0 -8.99999" album="Starter" material="cement10" texgens="0 -1 0 320 0 0 1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="288" owner="0" type="0" pos="-30 70.25 5.21461" rot="1 0 0 0" scale="" transform="1 0 0 -30 0 1 0 70.25 0 0 1.02247 5.21461 0 0 0 1" group="-1" locked="0" nextFaceID="2011" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="10 -0.25 -5.1" />
                            <Vertex pos="10 -0.25 3.8" />
                            <Vertex pos="10 0.25 3.8" />
                            <Vertex pos="10 0.25 -5.1" />
                            <Vertex pos="9 -0.25 -5.1" />
                            <Vertex pos="9 0.25 -5.1" />
                            <Vertex pos="9 0.25 3.8" />
                            <Vertex pos="9 -0.25 3.8" />
                        </Vertices>
                        <Face id="2004" plane="1 -0 0 -10" album="Starter" material="cement" texgens="0 1 0 8 0 0 -1 -163.2 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="2005" plane="0 0 -1 -5.1" album="Starter" material="cement" texgens="-1 0 0 320 0 -1 0 -8 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 4 0 3 5" />
                        </Face>
                        <Face id="2006" plane="0 1 -0 -0.25" album="Starter" material="cement" texgens="-1 0 0 320 0 0 -1 -163.2 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 5 3 2 6" />
                        </Face>
                        <Face id="2007" plane="0 -1 0 -0.25" album="Starter" material="cement" texgens="1 0 0 320 0 0 -1 -163.2 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 1 0 4 7" />
                        </Face>
                        <Face id="2008" plane="0 0 1 -3.8" album="Starter" material="cement" texgens="1 0 0 224 0 -1 0 -8 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 6 2 1 7" />
                        </Face>
                        <Face id="2009" plane="-1 0 0 9" album="Starter" material="cement" texgens="0 -1 0 320 0 0 1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="289" owner="0" type="0" pos="12.75 5 0.25" rot="1 0 0 0" scale="" transform="1 0 0 12.75 0 1 0 5 0 0 1 0.25 0 0 0 1" group="-1" locked="0" nextFaceID="2083" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="12.25 3.5 0.25" />
                            <Vertex pos="12.25 3.5 -0.25" />
                            <Vertex pos="12.25 -3.5 0.25" />
                            <Vertex pos="12.25 -3.5 -0.25" />
                            <Vertex pos="-12.25 3.5 0.25" />
                            <Vertex pos="-12.25 3.5 -0.25" />
                            <Vertex pos="-12.25 -3.5 0.25" />
                            <Vertex pos="-12.25 -3.5 -0.25" />
                        </Vertices>
                        <Face id="2076" plane="1 -0 0 -12.25" album="Starter" material="floor2" texgens="0 1 0 112 0 0 -1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2077" plane="-1 0 0 -12.25" album="Starter" material="floor2" texgens="0 -1 0 112 0 0 -1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2078" plane="0 1 -0 -3.5" album="Starter" material="floor2" texgens="-1 0 0 392 0 0 -1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2079" plane="0 -1 0 -3.5" album="Starter" material="floor2" texgens="1 0 0 392 0 0 -1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2080" plane="-0 0 1 -0.25" album="Starter" material="floor2" texgens="1 0 0 3468 0 -1 0 -1408 0 0.1 0.1" texRot="0" texScale="0.1 0.1" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2081" plane="0 0 -1 -0.25" album="Starter" material="floor2" texgens="-1 0 0 392 0 -1 0 -112 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="297" owner="0" type="0" pos="25.5 5 3.5" rot="1 0 0 0" scale="" transform="1 0 0 25.5 0 1 0 5 0 0 1 3.5 0 0 0 1" group="-1" locked="0" nextFaceID="1147" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 4 3.5" />
                            <Vertex pos="0.5 4 -3.5" />
                            <Vertex pos="0.5 -4 3.5" />
                            <Vertex pos="0.5 -4 -3.5" />
                            <Vertex pos="-0.5 4 3.5" />
                            <Vertex pos="-0.5 4 -3.5" />
                            <Vertex pos="-0.5 -4 3.5" />
                            <Vertex pos="-0.5 -4 -3.5" />
                        </Vertices>
                        <Face id="1140" plane="1 -0 0 -0.5" album="Starter" material="cement" texgens="0 1 0 128 0 0 -1 -112 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1141" plane="-1 0 0 -0.5" album="Starter" material="cement" texgens="0 -1 0 128 0 0 -1 -112 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1142" plane="0 1 -0 -4" album="Starter" material="cement" texgens="-1 0 0 16 0 0 -1 -112 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1143" plane="0 -1 0 -4" album="Starter" material="cement" texgens="1 0 0 16 0 0 -1 -112 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1144" plane="-0 0 1 -3.5" album="Starter" material="cement" texgens="1 0 0 16 0 -1 0 -128 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1145" plane="0 0 -1 -3.5" album="Starter" material="cement" texgens="-1 0 0 16 0 -1 0 -128 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="311" owner="0" type="0" pos="-29.6047 91.5 5.00158" rot="1 0 0 0" scale="" transform="1.16216 0 0 -29.6047 0 1 0 91.5 0 0 1.33298 5.00158 0 0 0 1" group="-1" locked="0" nextFaceID="1501" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="9.125 -0.5 -4.50235" />
                            <Vertex pos="9.125 -0.5 4.5" />
                            <Vertex pos="9.125 0.5 4.5" />
                            <Vertex pos="9.125 0.5 -4.50235" />
                            <Vertex pos="-9.375 -0.5 -4.50235" />
                            <Vertex pos="-9.375 0.5 -4.50235" />
                            <Vertex pos="-9.375 0.5 4.5" />
                            <Vertex pos="-9.375 -0.5 4.5" />
                        </Vertices>
                        <Face id="1494" plane="1 -0 0 -9.125" album="Starter" material="cement9" texgens="0 -0.953489 0 15.2554 0 0 -1 -144 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="1495" plane="0 0 -1 -4.50235" album="Starter" material="cement9" texgens="1.00244 0 0 332.812 0 -0.951158 0 -639.177 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 4 0 3 5" />
                        </Face>
                        <Face id="1496" plane="0 1 -0 -0.5" album="Starter" material="cement9" texgens="-1 0 0 332 0 0 -1 -160 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 5 3 2 6" />
                        </Face>
                        <Face id="1497" plane="-0 -1 -0 -0.5" album="Starter" material="cement9" texgens="1 0 0 332 0 0 -1 -160 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 7 1 0 4" />
                        </Face>
                        <Face id="1498" plane="0 0 1 -4.5" album="Starter" material="cement9" texgens="1 0 0 332 0 -0.953489 0 -640.745 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 1 7 6 2" />
                        </Face>
                        <Face id="1499" plane="-1 0 0 -9.375" album="Starter" material="cement9" texgens="0 0.953489 0 640.745 0 0 -1 -144 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="312" owner="0" type="0" pos="-20 35 10.6" rot="1 0 0 0" scale="" transform="1 0 0 -20 0 1 0 35 0 0 1 10.6 0 0 0 1" group="-1" locked="0" nextFaceID="7963" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1 -35.6 -0.9" />
                            <Vertex pos="-1 -35.6 0.9" />
                            <Vertex pos="1 -35.6 0.9" />
                            <Vertex pos="1 -35.6 -0.9" />
                            <Vertex pos="1 35.4999 0.9" />
                            <Vertex pos="1 35.4999 -0.9" />
                            <Vertex pos="-1 35.4999 -0.9" />
                            <Vertex pos="-1 35.4999 0.9" />
                        </Vertices>
                        <Face id="7956" plane="0 -1 0 -35.6" album="Starter" material="cement" texgens="1 0 0 32 0 0 -1 -28.8 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="7957" plane="1 -0 0 -1" album="Starter" material="cement" texgens="0 1 0 1139.2 0 0 -1 -28.8 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 3 2 4 5" />
                        </Face>
                        <Face id="7958" plane="-1 0 0 -1" album="Starter" material="cement" texgens="0 -1 0 1139.2 0 0 -1 -28.8 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 0 6 7 1" />
                        </Face>
                        <Face id="7959" plane="-0 0 1 -0.9" album="Starter" material="cement" texgens="1 0 0 32 0 -1 0 -1139.2 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 1 7 4 2" />
                        </Face>
                        <Face id="7960" plane="0 0 -1 -0.9" album="Starter" material="cement" texgens="-1 0 0 32 0 -1 0 -1139.2 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 0 3 5 6" />
                        </Face>
                        <Face id="7961" plane="0 1 0 -35.4999" album="colors" material="Black" texgens="0.951221 0 0 608.781 0 0 -0.995342 -35.1095 0 1 1" texRot="0" texScale="1 1" texDiv="16 16">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="316" owner="0" type="0" pos="-19.5 81.25 5.25" rot="1 0 0 0" scale="" transform="1 0 0 -19.5 0 1.04878 0 81.25 0 0 1.05556 5.25 0 0 0 1" group="-1" locked="0" nextFaceID="2545" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.5 -10.25 -4.5" />
                            <Vertex pos="-0.5 -10.25 4.5" />
                            <Vertex pos="0.5 -10.25 4.5" />
                            <Vertex pos="0.5 -10.25 -4.5" />
                            <Vertex pos="0.5 9.29651 4.5" />
                            <Vertex pos="0.5 9.29651 -4.5" />
                            <Vertex pos="-0.5 9.29651 -4.5" />
                            <Vertex pos="-0.5 9.29651 4.5" />
                        </Vertices>
                        <Face id="2538" plane="0 -1 0 -10.25" album="Starter" material="cement9" texgens="1 0 0 16 0 0 -1 -144 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="2539" plane="1 -0 0 -0.5" album="Starter" material="cement9" texgens="0 1 0 328 0 0 -1 -144 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 3 2 4 5" />
                        </Face>
                        <Face id="2540" plane="-1 0 0 -0.5" album="Starter" material="cement9" texgens="0 -1 0 328 0 0 -1 -144 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 0 6 7 1" />
                        </Face>
                        <Face id="2541" plane="-0 0 1 -4.5" album="Starter" material="cement9" texgens="1 0 0 16 0 -1 0 -328 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 1 7 4 2" />
                        </Face>
                        <Face id="2542" plane="0 0 -1 -4.5" album="Starter" material="cement9" texgens="-1 0 0 16 0 -1 0 -328 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 0 3 5 6" />
                        </Face>
                        <Face id="2543" plane="0 1 0 -9.29651" album="Starter" material="cement9" texgens="0.902438 0 0 609.561 0 0 -0.900236 -159.963 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="317" owner="0" type="0" pos="-39.5 81.25 5.25" rot="1 0 0 0" scale="" transform="1 0 0 -39.5 0 1.04878 0 81.25 0 0 1.05556 5.25 0 0 0 1" group="-1" locked="0" nextFaceID="2545" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.5 -10.25 -4.5" />
                            <Vertex pos="-0.5 -10.25 4.5" />
                            <Vertex pos="0.5 -10.25 4.5" />
                            <Vertex pos="0.5 -10.25 -4.5" />
                            <Vertex pos="0.5 9.29651 4.5" />
                            <Vertex pos="0.5 9.29651 -4.5" />
                            <Vertex pos="-0.5 9.29651 -4.5" />
                            <Vertex pos="-0.5 9.29651 4.5" />
                        </Vertices>
                        <Face id="2538" plane="0 -1 0 -10.25" album="Starter" material="cement9" texgens="1 0 0 16 0 0 -1 -144 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="2539" plane="1 -0 0 -0.5" album="Starter" material="cement9" texgens="0 1 0 328 0 0 -1 -144 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 3 2 4 5" />
                        </Face>
                        <Face id="2540" plane="-1 0 0 -0.5" album="Starter" material="cement9" texgens="0 -1 0 328 0 0 -1 -144 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 0 6 7 1" />
                        </Face>
                        <Face id="2541" plane="-0 0 1 -4.5" album="Starter" material="cement9" texgens="1 0 0 16 0 -1 0 -328 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 1 7 4 2" />
                        </Face>
                        <Face id="2542" plane="0 0 -1 -4.5" album="Starter" material="cement9" texgens="-1 0 0 16 0 -1 0 -328 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 0 3 5 6" />
                        </Face>
                        <Face id="2543" plane="0 1 0 -9.29651" album="Starter" material="cement9" texgens="0.902438 0 0 46.4397 0 0 -0.900236 -159.963 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="318" owner="0" type="0" pos="-29.1987 81.25 10.5" rot="1 0 0 0" scale="" transform="1.10256 0 0 -29.1987 0 1.05136 0 81.25 0 0 2.00012 10.5 0 0 0 1" group="-1" locked="0" nextFaceID="1687" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-10.25 -10.2249 -0.249986" />
                            <Vertex pos="-10.25 -10.2249 0.249986" />
                            <Vertex pos="9.25 -10.2249 0.249986" />
                            <Vertex pos="9.25 -10.2249 -0.249986" />
                            <Vertex pos="-10.25 9.2737 -0.249986" />
                            <Vertex pos="-10.25 9.2737 0.249986" />
                            <Vertex pos="9.25 9.2737 0.249986" />
                            <Vertex pos="9.25 9.2737 -0.249986" />
                        </Vertices>
                        <Face id="1680" plane="0 -1 0 -10.2249" album="Starter" material="cement9" texgens="1 0 0 328 0 0 -1 -7.99955 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="1681" plane="-1 0 0 -10.25" album="Starter" material="cement9" texgens="0 -1 0 327.197 0 0 -1 -7.99955 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 0 4 5 1" />
                        </Face>
                        <Face id="1682" plane="-0 0 1 -0.249986" album="Starter" material="cement9" texgens="1 0 0 328 0 -1 0 -327.197 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 1 5 6 2" />
                        </Face>
                        <Face id="1683" plane="0 0 -1 -0.249986" album="Starter" material="cement9" texgens="-1 0 0 328 0 -1 0 -327.197 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 0 3 7 4" />
                        </Face>
                        <Face id="1684" plane="1 -0 0 -9.25" album="Starter" material="cement9" texgens="0 -0.955825 0 343.256 0 0 -0.99998 -295.925 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 3 2 6 7" />
                        </Face>
                        <Face id="1685" plane="0 1 0 -9.2737" album="Starter" material="cement9" texgens="0.948715 0 0 343.178 0 0 -0.904449 -296.765 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="328" owner="0" type="0" pos="-29.9999 70.25 -0.144195" rot="1 0 0 0" scale="" transform="1 0 0 -29.9999 0 1 0 70.25 0 0 1 -0.144195 0 0 0 1" group="-1" locked="0" nextFaceID="2197" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="7.00005 0.25 0.355802" />
                            <Vertex pos="7.00005 0.25 -0.355802" />
                            <Vertex pos="7.00005 -0.25 0.355802" />
                            <Vertex pos="7.00005 -0.25 -0.355802" />
                            <Vertex pos="-7.00005 0.25 0.355802" />
                            <Vertex pos="-7.00005 0.25 -0.355802" />
                            <Vertex pos="-7.00005 -0.25 0.355802" />
                            <Vertex pos="-7.00005 -0.25 -0.355802" />
                        </Vertices>
                        <Face id="2190" plane="1 -0 0 -7.00005" album="colors" material="Black" texgens="0 1 0 8 0 0 -1 -11.3857 0 1 1" texRot="0" texScale="1 1" texDiv="16 16">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2191" plane="-1 0 0 -7.00005" album="colors" material="Black" texgens="0 -1 0 8 0 0 -1 -11.3857 0 1 1" texRot="0" texScale="1 1" texDiv="16 16">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2192" plane="0 1 -0 -0.25" album="colors" material="Black" texgens="-1 0 0 224.002 0 0 -1 -11.3857 0 1 1" texRot="0" texScale="1 1" texDiv="16 16">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2193" plane="0 -1 0 -0.25" album="colors" material="Black" texgens="1 0 0 224.002 0 0 -1 -11.3857 0 1 1" texRot="0" texScale="1 1" texDiv="16 16">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2194" plane="-0 0 1 -0.355802" album="Starter" material="cement" texgens="1 0 0 224.002 0 -1 0 -8 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2195" plane="0 0 -1 -0.355802" album="colors" material="Black" texgens="-1 0 0 224.002 0 -1 0 -8 0 1 1" texRot="0" texScale="1 1" texDiv="16 16">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="329" owner="0" type="0" pos="-30 70.25 5.21461" rot="1 0 0 0" scale="" transform="1 0 0 -30 0 1 0 70.25 0 0 1.02247 5.21461 0 0 0 1" group="-1" locked="0" nextFaceID="2017" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="7 0.25 3.8" />
                            <Vertex pos="9 0.25 3.8" />
                            <Vertex pos="9 -0.25 3.8" />
                            <Vertex pos="7 -0.25 3.8" />
                            <Vertex pos="7 -0.25 -4.89306" />
                            <Vertex pos="7 0.25 -4.89306" />
                            <Vertex pos="9 0.25 -4.89306" />
                            <Vertex pos="9 -0.25 -4.89306" />
                        </Vertices>
                        <Face id="2010" plane="0 0 1 -3.8" album="TGEDemo" material="Mtl" texgens="1 0 0 224 0 -1 0 -8 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="2011" plane="-1 0 0 7" album="TGEDemo" material="Mtl" texgens="0 1 0 8 0 0 -1 -169.6 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 4 5 0" />
                        </Face>
                        <Face id="2012" plane="0 1 0 -0.25" album="Starter" material="cement10" texgens="-1 0 0 320 0 0 -1 -163.2 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 6 1 0 5" />
                        </Face>
                        <Face id="2013" plane="0 -1 0 -0.25" album="Starter" material="cement10" texgens="1 0 0 320 0 0 -1 -163.2 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 4 3 2 7" />
                        </Face>
                        <Face id="2014" plane="1 0 0 -9" album="Starter" material="cement10" texgens="0 -1 0 320 0 0 1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 2 1 6 7" />
                        </Face>
                        <Face id="2015" plane="-0 -0 -1 -4.89306" album="Starter" material="cement" texgens="1 0 0 223.999 0 -1 0 -8 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="330" owner="0" type="0" pos="-30 70.25 5.21461" rot="1 0 0 0" scale="" transform="1 0 0 -30 0 1 0 70.25 0 0 1.02247 5.21461 0 0 0 1" group="-1" locked="0" nextFaceID="2017" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="7 -0.25 -5.1" />
                            <Vertex pos="9 -0.25 -5.1" />
                            <Vertex pos="9 0.25 -5.1" />
                            <Vertex pos="7 0.25 -5.1" />
                            <Vertex pos="7 -0.25 -4.89306" />
                            <Vertex pos="7 0.25 -4.89306" />
                            <Vertex pos="9 0.25 -4.89306" />
                            <Vertex pos="9 -0.25 -4.89306" />
                        </Vertices>
                        <Face id="2010" plane="0 0 -1 -5.1" album="Starter" material="cement10" texgens="-1 0 0 320 0 -1 0 -8 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="2011" plane="-1 0 0 7" album="TGEDemo" material="Mtl" texgens="0 1 0 8 0 0 -1 -169.6 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 4 0 3 5" />
                        </Face>
                        <Face id="2012" plane="0 1 -0 -0.25" album="Starter" material="cement10" texgens="-1 0 0 320 0 0 -1 -163.2 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 3 2 6 5" />
                        </Face>
                        <Face id="2013" plane="0 -1 0 -0.25" album="Starter" material="cement10" texgens="1 0 0 320 0 0 -1 -163.2 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 1 0 4 7" />
                        </Face>
                        <Face id="2014" plane="1 0 -0 -9" album="Starter" material="cement10" texgens="0 -1 0 320 0 0 1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 6 2 1 7" />
                        </Face>
                        <Face id="2015" plane="0 0 1 4.89306" album="Starter" material="cement" texgens="1 0 0 223.999 0 -1 0 -8 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="331" owner="0" type="0" pos="-29.75 80.75 0" rot="1 0 0 0" scale="" transform="1 0 0 -29.75 0 1 0 80.75 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="1651" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="11.25 10.25 0.5" />
                            <Vertex pos="11.25 10.25 -0.5" />
                            <Vertex pos="11.25 -10.25 0.5" />
                            <Vertex pos="11.25 -10.25 -0.5" />
                            <Vertex pos="-11.25 10.25 0.5" />
                            <Vertex pos="-11.25 10.25 -0.5" />
                            <Vertex pos="-11.25 -10.25 0.5" />
                            <Vertex pos="-11.25 -10.25 -0.5" />
                        </Vertices>
                        <Face id="1644" plane="1 -0 0 -11.25" album="Starter" material="cement9" texgens="0 1 0 328 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1645" plane="-1 0 0 -11.25" album="Starter" material="cement9" texgens="0 -1 0 328 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1646" plane="0 1 -0 -10.25" album="Starter" material="cement9" texgens="-1 0 0 360 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1647" plane="0 -1 0 -10.25" album="Starter" material="cement9" texgens="1 0 0 360 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1648" plane="-0 0 1 -0.5" album="Starter" material="cement9" texgens="1 0 0 360 0 -1 0 -328 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1649" plane="0 0 -1 -0.5" album="Starter" material="cement9" texgens="-1 0 0 360 0 -1 0 -328 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="355" owner="0" type="0" pos="12.5 1.25 3" rot="1 0 0 0" scale="" transform="1.02041 0 0 12.5 0 1 0 1.25 0 0 1 3 0 0 0 1" group="-1" locked="0" nextFaceID="1753" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="12.25 -0.25 -3" />
                            <Vertex pos="12.25 -0.25 3" />
                            <Vertex pos="12.25 0.25 3" />
                            <Vertex pos="12.25 0.25 -3" />
                            <Vertex pos="-11.76 0.25 -3" />
                            <Vertex pos="-11.76 0.25 3" />
                            <Vertex pos="-11.76 -0.25 3" />
                            <Vertex pos="-11.76 -0.25 -3" />
                        </Vertices>
                        <Face id="1746" plane="1 -0 0 -12.25" album="Starter" material="cement" texgens="0 1 0 8 0 0 -1 -96 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="1747" plane="0 1 -0 -0.25" album="Starter" material="cement" texgens="-1 0 0 392 0 0 -1 -96 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 4 3 2 5" />
                        </Face>
                        <Face id="1748" plane="-0 -1 -0 -0.25" album="Starter" material="cement" texgens="1 0 0 392 0 0 -1 -96 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 6 1 0 7" />
                        </Face>
                        <Face id="1749" plane="0 0 1 -3" album="Starter" material="cement" texgens="1 0 0 392 0 -1 0 -8 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 5 2 1 6" />
                        </Face>
                        <Face id="1750" plane="0 0 -1 -3" album="Starter" material="cement" texgens="-1 0 0 392 0 -1 0 -8 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 7 0 3 4" />
                        </Face>
                        <Face id="1751" plane="-1 0 0 -11.76" album="Starter" material="cement" texgens="0 1 0 40 0 0 -1 -96 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="356" owner="0" type="0" pos="12.5 8.75 3" rot="1 0 0 0" scale="" transform="1.02041 0 0 12.5 0 1 0 8.75 0 0 1 3 0 0 0 1" group="-1" locked="0" nextFaceID="1753" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="12.25 -0.25 -3" />
                            <Vertex pos="12.25 -0.25 3" />
                            <Vertex pos="12.25 0.25 3" />
                            <Vertex pos="12.25 0.25 -3" />
                            <Vertex pos="-11.76 0.25 -3" />
                            <Vertex pos="-11.76 0.25 3" />
                            <Vertex pos="-11.76 -0.25 3" />
                            <Vertex pos="-11.76 -0.25 -3" />
                        </Vertices>
                        <Face id="1746" plane="1 -0 0 -12.25" album="Starter" material="cement" texgens="0 1 0 8 0 0 -1 -96 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="1747" plane="0 1 -0 -0.25" album="Starter" material="cement" texgens="-1 0 0 392 0 0 -1 -96 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 4 3 2 5" />
                        </Face>
                        <Face id="1748" plane="-0 -1 -0 -0.25" album="Starter" material="cement" texgens="1 0 0 392 0 0 -1 -96 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 6 1 0 7" />
                        </Face>
                        <Face id="1749" plane="0 0 1 -3" album="Starter" material="cement" texgens="1 0 0 392 0 -1 0 -8 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 5 2 1 6" />
                        </Face>
                        <Face id="1750" plane="0 0 -1 -3" album="Starter" material="cement" texgens="-1 0 0 392 0 -1 0 -8 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 7 0 3 4" />
                        </Face>
                        <Face id="1751" plane="-1 0 0 -11.76" album="Starter" material="cement" texgens="0 1 0 280 0 0 -1 -96 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="357" owner="0" type="0" pos="12.5 5.00001 6.5" rot="1 0 0 0" scale="" transform="1.02041 0 0 12.5 0 7.94726e-008 -1.33333 5.00001 0 2 1.19209e-007 6.5 0 0 0 1" group="-1" locked="0" nextFaceID="1765" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="12.25 -0.25 0.750002" />
                            <Vertex pos="12.25 -0.25 3" />
                            <Vertex pos="12.25 0.25 3" />
                            <Vertex pos="12.25 0.25 0.750002" />
                            <Vertex pos="-11.76 0.25 3" />
                            <Vertex pos="-11.76 -0.25 3" />
                            <Vertex pos="-11.76 0.25 0.750002" />
                            <Vertex pos="-11.76 -0.25 0.750002" />
                        </Vertices>
                        <Face id="1758" plane="1 -0 0 -12.25" album="Starter" material="cement" texgens="0 1 0 8 0 0 -1 -96 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="1759" plane="0 0 1 -3" album="Starter" material="cement" texgens="1 0 0 392 0 -1 0 -8 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 4 2 1 5" />
                        </Face>
                        <Face id="1760" plane="0 1 0 -0.25" album="Starter" material="cement" texgens="-1 0 0 392 0 0 -1 -96 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 3 2 4 6" />
                        </Face>
                        <Face id="1761" plane="-0 -1 -0 -0.25" album="Starter" material="cement" texgens="1 0 0 392 0 0 -1 -96 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 5 1 0 7" />
                        </Face>
                        <Face id="1762" plane="0 0 -1 0.750002" album="Starter" material="cement" texgens="0 1 0 8 1 0 0 -96 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 7 0 3 6" />
                        </Face>
                        <Face id="1763" plane="-1 0 0 -11.76" album="Starter" material="cement" texgens="0 0 -1.33333 160 0 -2 0 -208 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="358" owner="0" type="0" pos="12.5 5.00001 6.5" rot="1 0 0 0" scale="" transform="1.02041 0 0 12.5 0 7.94726e-008 -1.33333 5.00001 0 2 1.19209e-007 6.5 0 0 0 1" group="-1" locked="0" nextFaceID="1765" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="12.25 -0.25 -0.750002" />
                            <Vertex pos="12.25 -0.25 0.750002" />
                            <Vertex pos="12.25 0.25 0.750002" />
                            <Vertex pos="12.25 0.25 -0.750002" />
                            <Vertex pos="-11.76 -0.25 -0.750002" />
                            <Vertex pos="-11.76 0.25 -0.750002" />
                            <Vertex pos="-11.76 0.25 0.750002" />
                            <Vertex pos="-11.76 -0.25 0.750002" />
                        </Vertices>
                        <Face id="1758" plane="1 -0 0 -12.25" album="Starter" material="panel2" texgens="0 1 0 8 0 0 -1 -96 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="1759" plane="0 0 -1 -0.750002" album="Starter" material="panel2" texgens="0 1 0 8 1 0 0 -96 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 4 0 3 5" />
                        </Face>
                        <Face id="1760" plane="0 1 0 -0.25" album="Starter" material="panel2" texgens="-1 0 0 392 0 0 -1 -96 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 3 2 6 5" />
                        </Face>
                        <Face id="1761" plane="-0 -1 -0 -0.25" album="Starter" material="panel2" texgens="-1 0 0 272 0 0 1.33333 -245.333 0 0.12 0.12" texRot="0" texScale="0.12 0.12" texDiv="512 512">
                            <Indices indices=" 7 1 0 4" />
                        </Face>
                        <Face id="1762" plane="0 0 1 -0.750002" album="Starter" material="panel2" texgens="0 1 0 8 1 0 0 -96 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 6 2 1 7" />
                        </Face>
                        <Face id="1763" plane="-1 0 0 -11.76" album="Starter" material="cement" texgens="0 0 -1.33333 160 0 -2 0 -208 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="359" owner="0" type="0" pos="12.5 4.80003 6.5" rot="1 0 0 0" scale="" transform="1.02041 0 0 12.5 0 9.53664e-008 -1.59998 4.80003 0 2 1.19209e-007 6.5 0 0 0 1" group="-1" locked="0" nextFaceID="1765" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="12.25 -0.25 -2.62501" />
                            <Vertex pos="12.25 -0.25 -0.750002" />
                            <Vertex pos="12.25 0.25 -0.750002" />
                            <Vertex pos="12.25 0.25 -2.62501" />
                            <Vertex pos="-11.76 0.25 -0.750002" />
                            <Vertex pos="-11.76 -0.25 -0.750002" />
                            <Vertex pos="-11.76 0.25 -2.62501" />
                            <Vertex pos="-11.76 -0.25 -2.62501" />
                        </Vertices>
                        <Face id="1758" plane="1 -0 0 -12.25" album="Starter" material="cement" texgens="0 1 0 8 0 0 -1 -96 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="1759" plane="0 0 1 0.750002" album="Starter" material="cement" texgens="0 1 0 8 1 0 0 -96 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 4 2 1 5" />
                        </Face>
                        <Face id="1760" plane="0 1 0 -0.25" album="Starter" material="cement" texgens="-1 0 0 392 0 0 -1 -96 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 3 2 4 6" />
                        </Face>
                        <Face id="1761" plane="-0 -1 -0 -0.25" album="Starter" material="cement" texgens="1 0 0 392 0 0 -1 -96 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 5 1 0 7" />
                        </Face>
                        <Face id="1762" plane="0 0 -1 -2.62501" album="Starter" material="cement" texgens="1 0 0 392 0 -2 0 -208 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 7 0 3 6" />
                        </Face>
                        <Face id="1763" plane="-1 0 0 -11.76" album="Starter" material="cement" texgens="0 0 -1.33333 160 0 -2 0 -208 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="360" owner="0" type="0" pos="-30 0 0.25" rot="1 0 0 0" scale="" transform="1 0 0 -30 0 2.5 0 0 0 0 1 0.25 0 0 0 1" group="-1" locked="0" nextFaceID="1027" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-12 20 0.25" />
                            <Vertex pos="-30 20 0.25" />
                            <Vertex pos="-30 20 -0.25" />
                            <Vertex pos="-12 20 -0.25" />
                            <Vertex pos="-30 16 -0.25" />
                            <Vertex pos="-30 16 0.25" />
                            <Vertex pos="-12 16 0.25" />
                            <Vertex pos="-12 16 -0.25" />
                        </Vertices>
                        <Face id="1020" plane="-0 1 0 -20" album="TGEDemo" material="asfalt_001" texgens="1 0 0 960 0 0 1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="1021" plane="-1 0 0 -30" album="TGEDemo" material="asfalt_001" texgens="0 -1 0 960 0 0 -1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 4 2 1 5" />
                        </Face>
                        <Face id="1022" plane="-0 0 1 -0.25" album="TGEDemo" material="asfalt_001" texgens="1 0 0 1264 0 -1 0 2704 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 6" />
                        </Face>
                        <Face id="1023" plane="0 0 -1 -0.25" album="TGEDemo" material="asfalt_001" texgens="-1 0 0 960 0 -1 0 -960 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 2 4 7" />
                        </Face>
                        <Face id="1024" plane="1 0 0 12" album="TGEDemo" material="asfalt_001" texgens="0 -1 0 960 0 0 1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 7 6 0" />
                        </Face>
                        <Face id="1025" plane="0 -1 0 16" album="TGEDemo" material="asfalt_001" texgens="-1 0 0 960 0 0 1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="362" owner="0" type="0" pos="-30 0 0.25" rot="1 0 0 0" scale="" transform="1 0 0 -30 0 2.5 0 0 0 0 1 0.25 0 0 0 1" group="-1" locked="0" nextFaceID="1033" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-12 16 -0.25" />
                            <Vertex pos="-12 16 0.25" />
                            <Vertex pos="-30 16 0.25" />
                            <Vertex pos="-30 16 -0.25" />
                            <Vertex pos="-30 12 -0.25" />
                            <Vertex pos="-30 12 0.25" />
                            <Vertex pos="-12 12 0.25" />
                            <Vertex pos="-12 12 -0.25" />
                        </Vertices>
                        <Face id="1026" plane="0 1 0 -16" album="TGEDemo" material="asfalt_001" texgens="-1 0 0 960 0 0 1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="1027" plane="-1 0 0 -30" album="TGEDemo" material="asfalt_001" texgens="0 -1 0 960 0 0 -1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 4 3 2 5" />
                        </Face>
                        <Face id="1028" plane="-0 0 1 -0.25" album="TGEDemo" material="asfalt_001" texgens="1 0 0 1264 0 -1 0 2704 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 2 1 6" />
                        </Face>
                        <Face id="1029" plane="0 0 -1 -0.25" album="TGEDemo" material="asfalt_001" texgens="-1 0 0 960 0 -1 0 -960 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 4 7 0" />
                        </Face>
                        <Face id="1030" plane="1 0 0 12" album="TGEDemo" material="asfalt_001" texgens="0 -1 0 960 0 0 1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 0 7 6 1" />
                        </Face>
                        <Face id="1031" plane="0 -1 0 12" album="TGEDemo" material="asfalt_001" texgens="-1 0 0 960 0 0 1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="364" owner="0" type="0" pos="-30 0 0.25" rot="1 0 0 0" scale="" transform="1 0 0 -30 0 2.5 0 0 0 0 1 0.25 0 0 0 1" group="-1" locked="0" nextFaceID="1039" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-12 12 -0.25" />
                            <Vertex pos="-12 12 0.25" />
                            <Vertex pos="-30 12 0.25" />
                            <Vertex pos="-30 12 -0.25" />
                            <Vertex pos="-30 8 -0.25" />
                            <Vertex pos="-30 8 0.25" />
                            <Vertex pos="-12 8 0.25" />
                            <Vertex pos="-12 8 -0.25" />
                        </Vertices>
                        <Face id="1032" plane="0 1 0 -12" album="TGEDemo" material="asfalt_001" texgens="-1 0 0 960 0 0 1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="1033" plane="-1 0 0 -30" album="TGEDemo" material="asfalt_001" texgens="0 -1 0 960 0 0 -1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 4 3 2 5" />
                        </Face>
                        <Face id="1034" plane="-0 0 1 -0.25" album="TGEDemo" material="asfalt_001" texgens="1 0 0 1264 0 -1 0 2704 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 2 1 6" />
                        </Face>
                        <Face id="1035" plane="0 0 -1 -0.25" album="TGEDemo" material="asfalt_001" texgens="-1 0 0 960 0 -1 0 -960 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 4 7 0" />
                        </Face>
                        <Face id="1036" plane="1 0 0 12" album="TGEDemo" material="asfalt_001" texgens="0 -1 0 960 0 0 1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 0 7 6 1" />
                        </Face>
                        <Face id="1037" plane="0 -1 0 8" album="TGEDemo" material="asfalt_001" texgens="-1 0 0 960 0 0 1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="366" owner="0" type="0" pos="-30 0 0.25" rot="1 0 0 0" scale="" transform="1 0 0 -30 0 2.5 0 0 0 0 1 0.25 0 0 0 1" group="-1" locked="0" nextFaceID="1045" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-12 8 -0.25" />
                            <Vertex pos="-12 8 0.25" />
                            <Vertex pos="-30 8 0.25" />
                            <Vertex pos="-30 8 -0.25" />
                            <Vertex pos="-30 7.2 -0.25" />
                            <Vertex pos="-30 7.2 0.25" />
                            <Vertex pos="-12 7.2 0.25" />
                            <Vertex pos="-12 7.2 -0.25" />
                        </Vertices>
                        <Face id="1038" plane="0 1 0 -8" album="TGEDemo" material="asfalt_001" texgens="-1 0 0 960 0 0 1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="1039" plane="-1 0 0 -30" album="TGEDemo" material="asfalt_001" texgens="0 -1 0 960 0 0 -1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 4 3 2 5" />
                        </Face>
                        <Face id="1040" plane="-0 0 1 -0.25" album="TGEDemo" material="asfalt_001" texgens="1 0 0 1264 0 -1 0 2704 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 2 1 6" />
                        </Face>
                        <Face id="1041" plane="0 0 -1 -0.25" album="TGEDemo" material="asfalt_001" texgens="-1 0 0 960 0 -1 0 -960 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 4 7 0" />
                        </Face>
                        <Face id="1042" plane="1 0 0 12" album="TGEDemo" material="asfalt_001" texgens="0 -1 0 960 0 0 1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 0 7 6 1" />
                        </Face>
                        <Face id="1043" plane="0 -1 0 7.2" album="TGEDemo" material="asfalt_001" texgens="-1 0 0 960 0 0 1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="368" owner="0" type="0" pos="-30 0 0.25" rot="1 0 0 0" scale="" transform="1 0 0 -30 0 2.5 0 0 0 0 1 0.25 0 0 0 1" group="-1" locked="0" nextFaceID="1051" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-12 7.2 -0.25" />
                            <Vertex pos="-12 7.2 0.25" />
                            <Vertex pos="-30 7.2 0.25" />
                            <Vertex pos="-30 7.2 -0.25" />
                            <Vertex pos="-30 6.4 -0.25" />
                            <Vertex pos="-30 6.4 0.25" />
                            <Vertex pos="-12 6.4 0.25" />
                            <Vertex pos="-12 6.4 -0.25" />
                        </Vertices>
                        <Face id="1044" plane="0 1 0 -7.2" album="TGEDemo" material="asfalt_001" texgens="-1 0 0 960 0 0 1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="1045" plane="-1 0 0 -30" album="TGEDemo" material="asfalt_001" texgens="0 -1 0 960 0 0 -1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 4 3 2 5" />
                        </Face>
                        <Face id="1046" plane="-0 0 1 -0.25" album="TGEDemo" material="asfalt_001" texgens="1 0 0 1264 0 -1 0 2704 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 2 1 6" />
                        </Face>
                        <Face id="1047" plane="0 0 -1 -0.25" album="TGEDemo" material="asfalt_001" texgens="-1 0 0 960 0 -1 0 -960 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 4 7 0" />
                        </Face>
                        <Face id="1048" plane="1 0 0 12" album="TGEDemo" material="asfalt_001" texgens="0 -1 0 960 0 0 1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 0 7 6 1" />
                        </Face>
                        <Face id="1049" plane="0 -1 0 6.4" album="TGEDemo" material="asfalt_001" texgens="-1 0 0 960 0 0 1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="370" owner="0" type="0" pos="-30 0 0.25" rot="1 0 0 0" scale="" transform="1 0 0 -30 0 2.5 0 0 0 0 1 0.25 0 0 0 1" group="-1" locked="0" nextFaceID="1057" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-12 6.4 -0.25" />
                            <Vertex pos="-12 6.4 0.25" />
                            <Vertex pos="-30 6.4 0.25" />
                            <Vertex pos="-30 6.4 -0.25" />
                            <Vertex pos="-30 5.6 -0.25" />
                            <Vertex pos="-30 5.6 0.25" />
                            <Vertex pos="-12 5.6 0.25" />
                            <Vertex pos="-12 5.6 -0.25" />
                        </Vertices>
                        <Face id="1050" plane="0 1 0 -6.4" album="TGEDemo" material="asfalt_001" texgens="-1 0 0 960 0 0 1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="1051" plane="-1 0 0 -30" album="TGEDemo" material="asfalt_001" texgens="0 -1 0 960 0 0 -1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 4 3 2 5" />
                        </Face>
                        <Face id="1052" plane="-0 0 1 -0.25" album="TGEDemo" material="asfalt_001" texgens="1 0 0 1264 0 -1 0 2704 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 2 1 6" />
                        </Face>
                        <Face id="1053" plane="0 0 -1 -0.25" album="TGEDemo" material="asfalt_001" texgens="-1 0 0 960 0 -1 0 -960 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 4 7 0" />
                        </Face>
                        <Face id="1054" plane="1 0 0 12" album="TGEDemo" material="asfalt_001" texgens="0 -1 0 960 0 0 1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 0 7 6 1" />
                        </Face>
                        <Face id="1055" plane="0 -1 0 5.6" album="TGEDemo" material="asfalt_001" texgens="-1 0 0 960 0 0 1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="372" owner="0" type="0" pos="-30 0 0.25" rot="1 0 0 0" scale="" transform="1 0 0 -30 0 2.5 0 0 0 0 1 0.25 0 0 0 1" group="-1" locked="0" nextFaceID="1063" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-12 5.6 -0.25" />
                            <Vertex pos="-12 5.6 0.25" />
                            <Vertex pos="-30 5.6 0.25" />
                            <Vertex pos="-30 5.6 -0.25" />
                            <Vertex pos="-30 4.8 -0.25" />
                            <Vertex pos="-30 4.8 0.25" />
                            <Vertex pos="-12 4.8 0.25" />
                            <Vertex pos="-12 4.8 -0.25" />
                        </Vertices>
                        <Face id="1056" plane="0 1 0 -5.6" album="TGEDemo" material="asfalt_001" texgens="-1 0 0 960 0 0 1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="1057" plane="-1 0 0 -30" album="TGEDemo" material="asfalt_001" texgens="0 -1 0 960 0 0 -1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 4 3 2 5" />
                        </Face>
                        <Face id="1058" plane="-0 0 1 -0.25" album="TGEDemo" material="asfalt_001" texgens="1 0 0 1264 0 -1 0 2704 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 2 1 6" />
                        </Face>
                        <Face id="1059" plane="0 0 -1 -0.25" album="TGEDemo" material="asfalt_001" texgens="-1 0 0 960 0 -1 0 -960 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 4 7 0" />
                        </Face>
                        <Face id="1060" plane="1 0 0 12" album="TGEDemo" material="asfalt_001" texgens="0 -1 0 960 0 0 1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 0 7 6 1" />
                        </Face>
                        <Face id="1061" plane="0 -1 0 4.8" album="TGEDemo" material="asfalt_001" texgens="-1 0 0 960 0 0 1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="374" owner="0" type="0" pos="-30 0 0.25" rot="1 0 0 0" scale="" transform="1 0 0 -30 0 2.5 0 0 0 0 1 0.25 0 0 0 1" group="-1" locked="0" nextFaceID="1069" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-12 4.8 -0.25" />
                            <Vertex pos="-12 4.8 0.25" />
                            <Vertex pos="-30 4.8 0.25" />
                            <Vertex pos="-30 4.8 -0.25" />
                            <Vertex pos="-30 4 -0.25" />
                            <Vertex pos="-30 4 0.25" />
                            <Vertex pos="-12 4 0.25" />
                            <Vertex pos="-12 4 -0.25" />
                        </Vertices>
                        <Face id="1062" plane="0 1 0 -4.8" album="TGEDemo" material="asfalt_001" texgens="-1 0 0 960 0 0 1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="1063" plane="-1 0 0 -30" album="TGEDemo" material="asfalt_001" texgens="0 -1 0 960 0 0 -1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 4 3 2 5" />
                        </Face>
                        <Face id="1064" plane="-0 0 1 -0.25" album="TGEDemo" material="asfalt_001" texgens="1 0 0 1264 0 -1 0 2704 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 2 1 6" />
                        </Face>
                        <Face id="1065" plane="0 0 -1 -0.25" album="TGEDemo" material="asfalt_001" texgens="-1 0 0 960 0 -1 0 -960 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 4 7 0" />
                        </Face>
                        <Face id="1066" plane="1 0 0 12" album="TGEDemo" material="asfalt_001" texgens="0 -1 0 960 0 0 1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 0 7 6 1" />
                        </Face>
                        <Face id="1067" plane="0 -1 0 4" album="TGEDemo" material="asfalt_001" texgens="-1 0 0 960 0 0 1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="376" owner="0" type="0" pos="-30 0 0.25" rot="1 0 0 0" scale="" transform="1 0 0 -30 0 2.5 0 0 0 0 1 0.25 0 0 0 1" group="-1" locked="0" nextFaceID="1075" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-12 4 -0.25" />
                            <Vertex pos="-12 4 0.25" />
                            <Vertex pos="-30 4 0.25" />
                            <Vertex pos="-30 4 -0.25" />
                            <Vertex pos="-30 3.2 -0.25" />
                            <Vertex pos="-30 3.2 0.25" />
                            <Vertex pos="-12 3.2 0.25" />
                            <Vertex pos="-12 3.2 -0.25" />
                        </Vertices>
                        <Face id="1068" plane="0 1 0 -4" album="TGEDemo" material="asfalt_001" texgens="-1 0 0 960 0 0 1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="1069" plane="-1 0 0 -30" album="TGEDemo" material="asfalt_001" texgens="0 -1 0 960 0 0 -1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 4 3 2 5" />
                        </Face>
                        <Face id="1070" plane="-0 0 1 -0.25" album="TGEDemo" material="asfalt_001" texgens="1 0 0 1264 0 -1 0 2704 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 2 1 6" />
                        </Face>
                        <Face id="1071" plane="0 0 -1 -0.25" album="TGEDemo" material="asfalt_001" texgens="-1 0 0 960 0 -1 0 -960 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 4 7 0" />
                        </Face>
                        <Face id="1072" plane="1 0 0 12" album="TGEDemo" material="asfalt_001" texgens="0 -1 0 960 0 0 1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 0 7 6 1" />
                        </Face>
                        <Face id="1073" plane="0 -1 0 3.2" album="TGEDemo" material="asfalt_001" texgens="-1 0 0 960 0 0 1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="378" owner="0" type="0" pos="-30 0 0.25" rot="1 0 0 0" scale="" transform="1 0 0 -30 0 2.5 0 0 0 0 1 0.25 0 0 0 1" group="-1" locked="0" nextFaceID="1081" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-12 3.2 -0.25" />
                            <Vertex pos="-12 3.2 0.25" />
                            <Vertex pos="-30 3.2 0.25" />
                            <Vertex pos="-30 3.2 -0.25" />
                            <Vertex pos="-30 2.4 -0.25" />
                            <Vertex pos="-30 2.4 0.25" />
                            <Vertex pos="-12 2.4 0.25" />
                            <Vertex pos="-12 2.4 -0.25" />
                        </Vertices>
                        <Face id="1074" plane="0 1 0 -3.2" album="TGEDemo" material="asfalt_001" texgens="-1 0 0 960 0 0 1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="1075" plane="-1 0 0 -30" album="TGEDemo" material="asfalt_001" texgens="0 -1 0 960 0 0 -1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 4 3 2 5" />
                        </Face>
                        <Face id="1076" plane="-0 0 1 -0.25" album="TGEDemo" material="asfalt_001" texgens="1 0 0 1264 0 -1 0 2704 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 2 1 6" />
                        </Face>
                        <Face id="1077" plane="0 0 -1 -0.25" album="TGEDemo" material="asfalt_001" texgens="-1 0 0 960 0 -1 0 -960 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 4 7 0" />
                        </Face>
                        <Face id="1078" plane="1 0 0 12" album="TGEDemo" material="asfalt_001" texgens="0 -1 0 960 0 0 1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 0 7 6 1" />
                        </Face>
                        <Face id="1079" plane="0 -1 0 2.4" album="TGEDemo" material="asfalt_001" texgens="-1 0 0 960 0 0 1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="380" owner="0" type="0" pos="-30 0 0.25" rot="1 0 0 0" scale="" transform="1 0 0 -30 0 2.5 0 0 0 0 1 0.25 0 0 0 1" group="-1" locked="0" nextFaceID="1087" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-12 2.4 -0.25" />
                            <Vertex pos="-12 2.4 0.25" />
                            <Vertex pos="-30 2.4 0.25" />
                            <Vertex pos="-30 2.4 -0.25" />
                            <Vertex pos="-30 1.6 -0.25" />
                            <Vertex pos="-30 1.6 0.25" />
                            <Vertex pos="-12 1.6 0.25" />
                            <Vertex pos="-12 1.6 -0.25" />
                        </Vertices>
                        <Face id="1080" plane="0 1 0 -2.4" album="TGEDemo" material="asfalt_001" texgens="-1 0 0 960 0 0 1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="1081" plane="-1 0 0 -30" album="TGEDemo" material="asfalt_001" texgens="0 -1 0 960 0 0 -1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 4 3 2 5" />
                        </Face>
                        <Face id="1082" plane="-0 0 1 -0.25" album="TGEDemo" material="asfalt_001" texgens="1 0 0 1264 0 -1 0 2704 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 2 1 6" />
                        </Face>
                        <Face id="1083" plane="0 0 -1 -0.25" album="TGEDemo" material="asfalt_001" texgens="-1 0 0 960 0 -1 0 -960 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 4 7 0" />
                        </Face>
                        <Face id="1084" plane="1 0 0 12" album="TGEDemo" material="asfalt_001" texgens="0 -1 0 960 0 0 1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 0 7 6 1" />
                        </Face>
                        <Face id="1085" plane="0 -1 0 1.6" album="TGEDemo" material="asfalt_001" texgens="-1 0 0 960 0 0 1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="382" owner="0" type="0" pos="-30 0 0.25" rot="1 0 0 0" scale="" transform="1 0 0 -30 0 2.5 0 0 0 0 1 0.25 0 0 0 1" group="-1" locked="0" nextFaceID="1093" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-12 1.6 -0.25" />
                            <Vertex pos="-12 1.6 0.25" />
                            <Vertex pos="-30 1.6 0.25" />
                            <Vertex pos="-30 1.6 -0.25" />
                            <Vertex pos="-30 0.8 -0.25" />
                            <Vertex pos="-30 0.8 0.25" />
                            <Vertex pos="-12 0.8 0.25" />
                            <Vertex pos="-12 0.8 -0.25" />
                        </Vertices>
                        <Face id="1086" plane="0 1 0 -1.6" album="TGEDemo" material="asfalt_001" texgens="-1 0 0 960 0 0 1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="1087" plane="-1 0 0 -30" album="TGEDemo" material="asfalt_001" texgens="0 -1 0 960 0 0 -1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 4 3 2 5" />
                        </Face>
                        <Face id="1088" plane="-0 0 1 -0.25" album="TGEDemo" material="asfalt_001" texgens="1 0 0 1264 0 -1 0 2704 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 2 1 6" />
                        </Face>
                        <Face id="1089" plane="0 0 -1 -0.25" album="TGEDemo" material="asfalt_001" texgens="-1 0 0 960 0 -1 0 -960 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 4 7 0" />
                        </Face>
                        <Face id="1090" plane="1 0 0 12" album="TGEDemo" material="asfalt_001" texgens="0 -1 0 960 0 0 1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 0 7 6 1" />
                        </Face>
                        <Face id="1091" plane="0 -1 0 0.8" album="TGEDemo" material="asfalt_001" texgens="-1 0 0 960 0 0 1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="383" owner="0" type="0" pos="-30 0 0.25" rot="1 0 0 0" scale="" transform="1 0 0 -30 0 2.5 0 0 0 0 1 0.25 0 0 0 1" group="-1" locked="0" nextFaceID="1093" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-12 -3.8743e-007 -0.25" />
                            <Vertex pos="-30 -3.8743e-007 -0.25" />
                            <Vertex pos="-30 -3.8743e-007 0.25" />
                            <Vertex pos="-12 -3.8743e-007 0.25" />
                            <Vertex pos="-30 0.8 -0.25" />
                            <Vertex pos="-30 0.8 0.25" />
                            <Vertex pos="-12 0.8 0.25" />
                            <Vertex pos="-12 0.8 -0.25" />
                        </Vertices>
                        <Face id="1086" plane="0 -1 0 -3.8743e-007" album="TGEDemo" material="asfalt_001" texgens="1 0 0 960 0 0 1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="1087" plane="-1 0 0 -30" album="TGEDemo" material="asfalt_001" texgens="0 -1 0 960 0 0 -1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="1088" plane="-0 0 1 -0.25" album="TGEDemo" material="asfalt_001" texgens="1 0 0 1264 0 -1 0 2704 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 2 5 6 3" />
                        </Face>
                        <Face id="1089" plane="0 0 -1 -0.25" album="TGEDemo" material="asfalt_001" texgens="-1 0 0 960 0 -1 0 -960 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 4 1 0 7" />
                        </Face>
                        <Face id="1090" plane="1 0 0 12" album="TGEDemo" material="asfalt_001" texgens="0 -1 0 960 0 0 1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 0 3 6" />
                        </Face>
                        <Face id="1091" plane="0 1 0 -0.8" album="TGEDemo" material="asfalt_001" texgens="-1 0 0 960 0 0 1 -8 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                </Brushes>
            </InteriorMap>
        </DetailLevel>
    </DetailLevels>
</ConstructorScene>
