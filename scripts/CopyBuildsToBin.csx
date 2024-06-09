const string BIN_DIR = "bin";
const string PROJECTS_DIR = "projects";

void CopyBuildsToBin() {
  if (Directory.Exists(BIN_DIR))
    Directory.Delete(BIN_DIR, true);
  Directory.CreateDirectory(BIN_DIR);

  foreach (var gameDir in Directory.EnumerateDirectories(PROJECTS_DIR)) {
    var gameName = Path.GetFileName(gameDir);
    if (new[] { "Web", "Quest" }.Contains(gameName))
      continue;
    foreach (var projectDir in Directory.EnumerateDirectories(gameDir)) {
      var buildFilename = $"{Path.GetFileName(projectDir)}.dll";
      var debugDir = Path.Combine(projectDir, "bin", "Debug");
      var buildFile = Path.Combine(debugDir, buildFilename);
      if (File.Exists(buildFile)) {
        File.Copy(buildFile,
                  Path.Combine(BIN_DIR, $"{gameName}{buildFilename}"));
      } else {
        foreach (var buildDir in Directory.EnumerateDirectories(debugDir)) {
          foreach (var file in Directory.EnumerateFiles(buildDir)) {
            var filename = Path.GetFileName(projectDir);
            if (filename.EndsWith(".dll")) {
              File.Copy(file, Path.Combine(BIN_DIR, $"{gameName}{filename}"));
            }
          }
        }
      }
    }
  }
}

try {
  CopyBuildsToBin();
  Console.WriteLine("All done!");
} catch (Exception ex) {
  Console.WriteLine(ex);
  Environment.Exit(1);
}
