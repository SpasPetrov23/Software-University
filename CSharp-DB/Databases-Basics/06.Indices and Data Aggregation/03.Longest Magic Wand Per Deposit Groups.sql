SELECT DepositGroup, MAX(MagicWandSize) AS LongestMagicWand
FROM WizzardDeposits AS LongestMagicWand
GROUP BY DepositGroup