using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Algo.Web.Services
{
    public static class TraverseTree
    {
        public static void DFS(string startPath, StringBuilder traversedPaths)
        {
            var path = new DirectoryInfo(startPath);
            traversedPaths.Append($"{path.FullName} <br />");

            var childs = path.GetDirectories();
            foreach (var folder in childs)
            {
                DFS(folder.FullName, traversedPaths);
            }
        }

        public static string BFS(string startPath)
        {
            var pathsToVisit = new Queue<DirectoryInfo>();

            var initialPath = new DirectoryInfo(startPath);
            var traversedPaths = new StringBuilder();

            pathsToVisit.Enqueue(initialPath);

            while (pathsToVisit.Count > 0)
            {
                var currentFolder = pathsToVisit.Dequeue();
                traversedPaths.Append($"{currentFolder.FullName} <br />");

                var childs = currentFolder.GetDirectories();
                foreach (var folder in childs)
                {
                    pathsToVisit.Enqueue(folder);
                }
            }

            return traversedPaths.ToString();
        }
    }
}