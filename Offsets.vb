#Region ""

Imports System.Linq

#End Region

Namespace vanick
	Public Class Offsets
		Public Class Signatures
			Public Property anim_overlays() As Integer
			Public Property clientstate_choked_commands() As Integer
			Public Property clientstate_delta_ticks() As Integer
			Public Property clientstate_last_outgoing_command() As Integer
			Public Property clientstate_net_channel() As Integer
			Public Property convar_name_hash_table() As Integer
			Public Property dwClientState() As Integer
			Public Property dwClientState_GetLocalPlayer() As Integer
			Public Property dwClientState_IsHLTV() As Integer
			Public Property dwClientState_Map() As Integer
			Public Property dwClientState_MapDirectory() As Integer
			Public Property dwClientState_MaxPlayer() As Integer
			Public Property dwClientState_PlayerInfo() As Integer
			Public Property dwClientState_State() As Integer
			Public Property dwClientState_ViewAngles() As Integer
			Public Property dwEntityList() As Integer
			Public Property dwForceAttack() As Integer
			Public Property dwForceAttack2() As Integer
			Public Property dwForceBackward() As Integer
			Public Property dwForceForward() As Integer
			Public Property dwForceJump() As Integer
			Public Property dwForceLeft() As Integer
			Public Property dwForceRight() As Integer
			Public Property dwGameDir() As Integer
			Public Property dwGameRulesProxy() As Integer
			Public Property dwGetAllClasses() As Integer
			Public Property dwGlobalVars() As Integer
			Public Property dwGlowObjectManager() As Integer
			Public Property dwInput() As Integer
			Public Property dwInterfaceLinkList() As Integer
			Public Property dwLocalPlayer() As Integer
			Public Property dwMouseEnable() As Integer
			Public Property dwMouseEnablePtr() As Integer
			Public Property dwPlayerResource() As Integer
			Public Property dwRadarBase() As Integer
			Public Property dwSensitivity() As Integer
			Public Property dwSensitivityPtr() As Integer
			Public Property dwSetClanTag() As Integer
			Public Property dwViewMatrix() As Integer
			Public Property dwWeaponTable() As Integer
			Public Property dwWeaponTableIndex() As Integer
			Public Property dwYawPtr() As Integer
			Public Property dwZoomSensitivityRatioPtr() As Integer
			Public Property dwbSendPackets() As Integer
			Public Property dwppDirect3DDevice9() As Integer
			Public Property find_hud_element() As Integer
			Public Property force_update_spectator_glow() As Integer
			Public Property interface_engine_cvar() As Integer
			Public Property is_c4_owner() As Integer
			Public Property m_bDormant() As Integer
			Public Property m_flSpawnTime() As Integer
			Public Property m_pStudioHdr() As Integer
			Public Property m_pitchClassPtr() As Integer
			Public Property m_yawClassPtr() As Integer
			Public Property model_ambient_min() As Integer
			Public Property set_abs_angles() As Integer
			Public Property set_abs_origin() As Integer
		End Class

		Public Class Netvars
			Public Property cs_gamerules_data() As Integer
			Public Property m_ArmorValue() As Integer
			Public Property m_Collision() As Integer
			Public Property m_CollisionGroup() As Integer
			Public Property m_Local() As Integer
			Public Property m_MoveType() As Integer
			Public Property m_OriginalOwnerXuidHigh() As Integer
			Public Property m_OriginalOwnerXuidLow() As Integer
			Public Property m_SurvivalGameRuleDecisionTypes() As Integer
			Public Property m_SurvivalRules() As Integer
			Public Property m_aimPunchAngle() As Integer
			Public Property m_aimPunchAngleVel() As Integer
			Public Property m_angEyeAnglesX() As Integer
			Public Property m_angEyeAnglesY() As Integer
			Public Property m_bBombDefused() As Integer
			Public Property m_bBombPlanted() As Integer
			Public Property m_bBombTicking() As Integer
			Public Property m_bFreezePeriod() As Integer
			Public Property m_bGunGameImmunity() As Integer
			Public Property m_bHasDefuser() As Integer
			Public Property m_bHasHelmet() As Integer
			Public Property m_bInReload() As Integer
			Public Property m_bIsDefusing() As Integer
			Public Property m_bIsQueuedMatchmaking() As Integer
			Public Property m_bIsScoped() As Integer
			Public Property m_bIsValveDS() As Integer
			Public Property m_bSpotted() As Integer
			Public Property m_bSpottedByMask() As Integer
			Public Property m_bStartedArming() As Integer
			Public Property m_bUseCustomAutoExposureMax() As Integer
			Public Property m_bUseCustomAutoExposureMin() As Integer
			Public Property m_bUseCustomBloomScale() As Integer
			Public Property m_clrRender() As Integer
			Public Property m_dwBoneMatrix() As Integer
			Public Property m_fAccuracyPenalty() As Integer
			Public Property m_fFlags() As Integer
			Public Property m_flC4Blow() As Integer
			Public Property m_flCustomAutoExposureMax() As Integer
			Public Property m_flCustomAutoExposureMin() As Integer
			Public Property m_flCustomBloomScale() As Integer
			Public Property m_flDefuseCountDown() As Integer
			Public Property m_flDefuseLength() As Integer
			Public Property m_flFallbackWear() As Integer
			Public Property m_flFlashDuration() As Integer
			Public Property m_flFlashMaxAlpha() As Integer
			Public Property m_flLastBoneSetupTime() As Integer
			Public Property m_flLowerBodyYawTarget() As Integer
			Public Property m_flNextAttack() As Integer
			Public Property m_flNextPrimaryAttack() As Integer
			Public Property m_flSimulationTime() As Integer
			Public Property m_flTimerLength() As Integer
			Public Property m_hActiveWeapon() As Integer
			Public Property m_hBombDefuser() As Integer
			Public Property m_hMyWeapons() As Integer
			Public Property m_hObserverTarget() As Integer
			Public Property m_hOwner() As Integer
			Public Property m_hOwnerEntity() As Integer
			Public Property m_hViewModel() As Integer
			Public Property m_iAccountID() As Integer
			Public Property m_iClip1() As Integer
			Public Property m_iCompetitiveRanking() As Integer
			Public Property m_iCompetitiveWins() As Integer
			Public Property m_iCrosshairId() As Integer
			Public Property m_iDefaultFOV() As Integer
			Public Property m_iEntityQuality() As Integer
			Public Property m_iFOVStart() As Integer
			Public Property m_iGlowIndex() As Integer
			Public Property m_iHealth() As Integer
			Public Property m_iItemDefinitionIndex() As Integer
			Public Property m_iItemIDHigh() As Integer
			Public Property m_iMostRecentModelBoneCounter() As Integer
			Public Property m_iObserverMode() As Integer
			Public Property m_iShotsFired() As Integer
			Public Property m_iState() As Integer
			Public Property m_iTeamNum() As Integer
			Public Property m_lifeState() As Integer
			Public Property m_nBombSite() As Integer
			Public Property m_nFallbackPaintKit() As Integer
			Public Property m_nFallbackSeed() As Integer
			Public Property m_nFallbackStatTrak() As Integer
			Public Property m_nForceBone() As Integer
			Public Property m_nTickBase() As Integer
			Public Property m_nViewModelIndex() As Integer
			Public Property m_rgflCoordinateFrame() As Integer
			Public Property m_szCustomName() As Integer
			Public Property m_szLastPlaceName() As Integer
			Public Property m_thirdPersonViewAngles() As Integer
			Public Property m_vecOrigin() As Integer
			Public Property m_vecVelocity() As Integer
			Public Property m_vecViewOffset() As Integer
			Public Property m_viewPunchAngle() As Integer
			Public Property m_zoomLevel() As Integer
		End Class

		Public Class OffsetMain
			Public Property timestamp() As Integer
			Public Property signatures() As Signatures
			Public Property netvars() As Netvars
		End Class
	End Class
End Namespace