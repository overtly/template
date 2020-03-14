$Path = Split-Path -Parent $MyInvocation.MyCommand.Definition;
$Path = "$Path\src"
$Prefix = "Overt.Template"

$OriginPrefix = ""
Get-ChildItem $Path | ForEach-Object -Process{
    if($_ -is [System.IO.DirectoryInfo] -and $_.Name.EndsWith("Service")){
        $OriginPrefix = $_.Name.Replace(".Service", "");
    }
}

Get-ChildItem $Path | ForEach-Object -Process{
    if($_ -is [System.IO.DirectoryInfo]){
        $newName = $_.Name.Replace($OriginPrefix, $Prefix);

        Write-Host $newName
        if($_.Name -ne $newName){
            Rename-Item $_.FullName -NewName $newName
        }
    }
}

Get-ChildItem $Path -Recurse | ForEach-Object -Process{
    if($_ -is [System.IO.FileInfo] -and $_.Name.EndsWith(".csproj")){
        $newName = $_.Name.Replace($OriginPrefix, $Prefix);
        Write-Host $newName
        if($_.Name -ne $newName){
            Rename-Item $_.FullName -NewName $newName
        }
    }
}