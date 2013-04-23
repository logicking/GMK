datablock StaticShapeData(Sparks)
{
   category = "Misc";
   shapeFile = "art/shapes/sparks/sparks.dts";
};

function Sparks::onAdd(%this,%obj)
{
   %obj.playThread(0,"action");
}