using Mapbox.Map;
using Mapbox.Unity.Map.Interfaces;
using Mapbox.Unity.Utilities;
using UnityEngine;

namespace Mapbox.Unity.Map.Strategies
{
	public class MapScalingAtUnityScaleStrategy : IMapScalingStrategy
	{
		public void SetUpScaling(AbstractMap map)
		{
			Debug.Log("MapScalingAtUnityScaleStrategy");
			var referenceTileRect = Conversions.TileBounds(TileCover.CoordinateToTileId(map.CenterLatitudeLongitude, map.AbsoluteZoom));
			map.SetWorldRelativeScale((float)(map.Options.scalingOptions.unityTileSize / referenceTileRect.Size.x));

			/*Debug.Log(map.AbsoluteZoom);
			Debug.Log(map.InitialZoom);
			Debug.Log($"{map.CenterLatitudeLongitude.x}, {map.CenterLatitudeLongitude.y}");
			Debug.Log($"{Mathf.Deg2Rad}");
			var scaleFactor = Mathf.Pow(2, (map.AbsoluteZoom - map.InitialZoom));
			map.SetWorldRelativeScale(scaleFactor * Mathf.Cos(Mathf.Deg2Rad * (float)map.CenterLatitudeLongitude.x));
*/
		}
	}
}
