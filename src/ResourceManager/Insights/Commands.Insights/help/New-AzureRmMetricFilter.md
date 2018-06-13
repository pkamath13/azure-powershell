﻿---
external help file: Microsoft.Azure.Commands.Insights.dll-Help.xml
Module Name: AzureRM.Insights
ms.assetid: B5F2388E-0136-4F8A-8577-67CE2A45671E
online version: https://docs.microsoft.com/en-us/powershell/module/azurerm.insights/new-azurermmetricfilter
schema: 2.0.0
---

# New-AzureRmMetricFilter

## SYNOPSIS
Creates a metric dimension filter that can be used to query metrics.

## SYNTAX

```
New-AzureRmMetricFilter -ResourceId <String> [-Name <String>] [-DefaultProfile <IAzureContextContainer>]
 [<CommonParameters>]
```

## DESCRIPTION
The **New-AzureRmMetricFilter** cmdlet creates a metric dimension filter that can be used to query metrics.

## EXAMPLES

### Example 1: Create a metric dimension filter
```
PS C:\>New-AzureRmMetricDimensionFilter -Dimension City -Operator eq -Values Seattle, New York
```

This command creates metric dimension filter of the format "City eq 'Seattle' or City eq 'New York'".

## PARAMETERS

### -Dimension
The name of the metric dimension. 

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: True
Position: 0
Default value: None
Accept pipeline input: True (ByPropertyName)
Accept wildcard characters: False
```

### -Operator
Specifies the operator used to select the metric dimension.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: True
Position: 1
Default value: None
Accept pipeline input: True (ByPropertyName)
Accept wildcard characters: False
```

### -Values
Specifies the array of metric dimension values.

```yaml
Type: String[]
Parameter Sets: (All)
Aliases:

Required: True
Position: 2
Default value: None
Accept pipeline input: True (ByPropertyName)
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see about_CommonParameters (http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### None
This cmdlet does not accept any input.

## OUTPUTS

### Microsoft.Azure.OperationResponse

## NOTES

## RELATED LINKS

[Get-AzureRmMetric](./Get-AzureRmMetric.md)
[Get-AzureRmMetricDefinition](./Get-AzureRmMetricDefinition.md)
