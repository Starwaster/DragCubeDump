
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using UnityEngine;

namespace BTSM
{
    [KSPAddon( KSPAddon.Startup.MainMenu, false )]
    class BTSMMonoBehaviorDebugOutput : MonoBehaviour
    {
        void Start()
        {
            OutputAllPartsDrag();
        }

        private void OutputAllPartsDrag()
        {
            if ( PartLoader.Instance != null && PartLoader.Instance.parts != null )
            {
                foreach ( AvailablePart tempAvailablePart in PartLoader.Instance.parts )
                {
                    if ( tempAvailablePart.partPrefab != null )
                    {
                        Part tempPart = tempAvailablePart.partPrefab;

                        Debug.Log( "Drag Cubes for: " + tempAvailablePart.name + ", " + tempAvailablePart.title );

                        foreach ( DragCube tempCube in tempPart.DragCubes.Cubes )
                        {
                            Debug.Log( "\r\n\tDRAG_CUBE\r\n\t{\r\n\t\tcube = " + tempCube.Name + ", " +
                                tempCube.Area[0] + "," + tempCube.Drag[0] + "," + tempCube.Depth[0] + ", " +
                                tempCube.Area[1] + "," + tempCube.Drag[1] + "," + tempCube.Depth[1] + ", " +
                                tempCube.Area[2] + "," + tempCube.Drag[2] + "," + tempCube.Depth[2] + ", " +
                                tempCube.Area[3] + "," + tempCube.Drag[3] + "," + tempCube.Depth[3] + ", " +
                                tempCube.Area[4] + "," + tempCube.Drag[4] + "," + tempCube.Depth[4] + ", " +
                                tempCube.Area[5] + "," + tempCube.Drag[5] + "," + tempCube.Depth[5] + ", " +
                                tempCube.Center.x + "," + tempCube.Center.y + "," + tempCube.Center.z + ", " +
                                tempCube.Size.x + "," + tempCube.Size.y + "," + tempCube.Size.z + 
                                "\r\n\t}\r\n" );
                        }
                    }
                }
            }
        }
    }
}