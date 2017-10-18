if(PAPILLON_BUILD_DIR)
    find_path(PAPILLON_BUILD_DIR NAMES include/PapillonCore/PapillonCore.h)
    find_library(PAPILLON_LIBRARIES NAMES PapillonCore PATHS ${PAPILLON_BUILD_DIR}/lib NO_DEFAULT_PATH)
    set(PAPILLON_INCLUDE_DIR ${PAPILLON_BUILD_DIR}/include/PapillonCore)
    set(PAPILLON_BIN_DIR ${PAPILLON_BUILD_DIR}/bin)
else()
    find_path($ENV{PAPILLON_INSTALL_DIR} NAMES include/PapillonCore/PapillonCore.h)
    find_library(PAPILLON_LIBRARIES NAMES PapillonCore PATHS $ENV{PAPILLON_INSTALL_DIR}/lib NO_DEFAULT_PATH)
    set(PAPILLON_INCLUDE_DIR $ENV{PAPILLON_INSTALL_DIR}/include/PapillonCore)
    set(PAPILLON_BIN_DIR $ENV{PAPILLON_INSTALL_DIR}/bin)
endif()



find_package_handle_standard_args(Papillon FOUND_VAR Papillon_FOUND REQUIRED_VARS PAPILLON_LIBRARIES PAPILLON_INCLUDE_DIR)
