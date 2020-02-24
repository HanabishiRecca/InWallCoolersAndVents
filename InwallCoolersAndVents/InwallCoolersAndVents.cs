using Verse;

public class PlaceWorker_WallRestriction : PlaceWorker {
    public override AcceptanceReport AllowsPlacing(BuildableDef checkingDef, IntVec3 loc, Rot4 rot, Map map, Thing thingToIgnore, Thing thing) =>
        ((loc.GetEdifice(map)?.def?.graphicData?.linkFlags & (LinkFlags.Rock | LinkFlags.Wall)) > 0) ? AcceptanceReport.WasAccepted : "MessagePlaceOnlyOnTheWall".Translate();
}
