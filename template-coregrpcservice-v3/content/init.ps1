$Path = Split-Path -Parent $MyInvocation.MyCommand.Definition;
$Path = "$Path\src"
$Prefix = "Overt.GrpcTemplate"
$ServicePrefix = "TemplateService"

$OriginPrefix = ""
Get-ChildItem $Path | ForEach-Object -Process{
    if($_ -is [System.IO.DirectoryInfo] -and $_.Name.EndsWith("Service")){
        $OriginPrefix = $_.Name.Replace(".Service", "");
    }
}

# 文件夹名称
Get-ChildItem $Path | ForEach-Object -Process{
    if($_ -is [System.IO.DirectoryInfo]){
        $newName = $_.Name.Replace($OriginPrefix, $Prefix);

        Write-Host $newName
        if($_.Name -ne $newName){
            Rename-Item $_.FullName -NewName $newName
        }
    }
}

# 项目文件名称
Get-ChildItem $Path -Recurse | ForEach-Object -Process{
    if($_ -is [System.IO.FileInfo] -and $_.Name.EndsWith(".csproj")){
        $newName = $_.Name.Replace($OriginPrefix, $Prefix);
        Write-Host $newName
        if($_.Name -ne $newName){
            Rename-Item $_.FullName -NewName $newName
        }
    }

	if($_ -is [System.IO.FileInfo] -and $_.Name.EndsWith("Impl.cs")){
        $newName = $ServicePrefix + "Impl.cs";
        Write-Host $newName
        if($_.Name -ne $newName){
            Rename-Item $_.FullName -NewName $newName
        }
    }

	if($_ -is [System.IO.FileInfo] -and $_.Name.EndsWith("Service.proto")){
        $newName = $ServicePrefix + ".proto";
        Write-Host $newName
        if($_.Name -ne $newName){
            Rename-Item $_.FullName -NewName $newName
        }
    }
}