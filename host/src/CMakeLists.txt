﻿# CMakeList.txt : Top-level CMake project file, do global configuration
# and include sub-projects here.
#
cmake_minimum_required (VERSION 3.23)

include(FetchContent)
FetchContent_Declare(vcpkg
    GIT_REPOSITORY https://github.com/microsoft/vcpkg/
    GIT_TAG 2022.11.14
)
FetchContent_MakeAvailable(vcpkg)

# NOTE: This must be defined before the first project call
set(CMAKE_TOOLCHAIN_FILE "${vcpkg_SOURCE_DIR}/scripts/buildsystems/vcpkg.cmake" CACHE FILEPATH "")

set(VCPKG_INSTALL_OPTIONS "--debug")

project ("FunctionsNetHost")
set(CMAKE_CXX_STANDARD 20)

# Include sub-projects.
add_subdirectory("Protos")
add_subdirectory ("FunctionsNetHost")
add_subdirectory("funcgrpc")

target_include_directories(FunctionsNetHost PUBLIC
        "${PROJECT_BINARY_DIR}"
        )